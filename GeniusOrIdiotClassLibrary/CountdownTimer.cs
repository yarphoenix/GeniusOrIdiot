namespace GeniusOrIdiotClassLibrary;

public class CountdownTimer : IDisposable
{
    private CancellationTokenSource? _cts;
    private readonly object _lock = new();
    private readonly SynchronizationContext? _syncContext;

    private bool _isPaused;
    private bool _disposed;

    public bool IsRunning { get; private set; }

    private int _remainingSeconds;
    public int RemainingSeconds
    {
        get
        {
            lock (_lock)
            {
                return _remainingSeconds;
            }
        }
        private set
        {
            lock (_lock)
            {
                _remainingSeconds = value;
            }
        }
    }

    public event Action<int>? Tick;
    public event Action? Finished;

    public CountdownTimer()
    {
        _syncContext = SynchronizationContext.Current;
    }

    public void Start(int seconds)
    {
        if (seconds < 0) throw new ArgumentOutOfRangeException(nameof(seconds));
        StopInternal();

        RemainingSeconds = seconds;
        _isPaused = false;
        _cts = new CancellationTokenSource();
        IsRunning = true;
        _ = RunLoopAsync(seconds, _cts.Token);
    }

    private async Task RunLoopAsync(int startSeconds, CancellationToken token)
    {
        var endTime = DateTime.UtcNow.AddSeconds(startSeconds);
        int lastReported = -1;

        try
        {
            while (true)
            {
                token.ThrowIfCancellationRequested();

                var rem = (int)Math.Max(0, Math.Ceiling((endTime - DateTime.UtcNow).TotalSeconds));
                RemainingSeconds = rem;

                if (rem != lastReported)
                {
                    Post(() => Tick?.Invoke(rem));
                    lastReported = rem;
                }

                if (rem <= 0) break;

                await Task.Delay(200, token).ConfigureAwait(false);
            }

            IsRunning = false;
            Post(() => Finished?.Invoke());
        }
        catch (OperationCanceledException)
        {
            IsRunning = false;
        }
        catch (Exception)
        {
            IsRunning = false;
            throw;
        }
    }

    public void Pause()
    {
        if (!IsRunning) return;
        _isPaused = true;
        _cts?.Cancel();
    }

    public void Resume()
    {
        if (!_isPaused) return;
        int rem = RemainingSeconds;
        if (rem <= 0) return;
        _isPaused = false;
        _cts = new CancellationTokenSource();
        IsRunning = true;
        _ = RunLoopAsync(rem, _cts.Token);
    }

    public void Stop()
    {
        StopInternal();
        RemainingSeconds = 0;
        Post(() => Tick?.Invoke(0));
    }

    private void StopInternal()
    {
        try
        {
            _cts?.Cancel();
            _cts?.Dispose();
        }
        catch
        {
            // ignored
        }
        finally
        {
            _cts = null;
            _isPaused = false;
            IsRunning = false;
        }
    }

    private void Post(Action? action)
    {
        if (action == null) return;
        var sc = _syncContext;
        if (sc != null)
        {
            sc.Post(_ => action(), null);
        }
        else
        {
            // No synchronization context captured - run on thread-pool to avoid blocking caller.
            Task.Run(action);
        }
    }

    public void Dispose()
    {
        if (_disposed) return;
        StopInternal();
        _disposed = true;
    }
}