namespace GeniusOrIdiotClassLibrary;

public class Game
{
    private const int TimePerQuestion = 10;

    private readonly CountdownTimer _timer = new();
    private readonly User _user;
    private readonly List<Question> _questions;
    private readonly int _questionCount;

    private Question _currentQuestion;
    private int _currentQuestionNumber;

    public event Action<int>? Tick;
    public event Action<Question>? QuestionChanged;
    public event Action<string>? GameEnded;

    public Game(User user)
    {
        _timer.Tick += seconds => Tick?.Invoke(seconds);

        _timer.Finished += OnTimerFinished;

        _user = user;
        _questions = QuestionsStorage.GetAll();
        _questionCount = _questions.Count;
    }

    private void OnTimerFinished()
    {
        if (_questions.Contains(_currentQuestion))
            _questions.Remove(_currentQuestion);

        if (_questions is { Count: 0 })
        {
            EndGame();
            return;
        }

        AdvanceToNextQuestion();
    }

    private void AdvanceToNextQuestion()
    {
        if (IsEnd())
        {
            EndGame();
            return;
        }

        var random = new Random();
        int nextQuestionIndex = random.Next(0, _questions.Count);

        _currentQuestion = _questions[nextQuestionIndex];
        _currentQuestionNumber++;

        _timer.Start(TimePerQuestion);

        QuestionChanged?.Invoke(_currentQuestion);
    }

    public Question GetNextQuestion()
    {
        AdvanceToNextQuestion();
        return _currentQuestion;
    }

    public string GetQuestionNumberText()
    {
        return _currentQuestionNumber.ToString();
    }

    public void AcceptAnswer(int userAnswer)
    {
        int rightAnswer = _currentQuestion.Answer;
        if (userAnswer == rightAnswer)
        {
            _user.AcceptRightAnswer();
        }

        if (_questions.Contains(_currentQuestion))
            _questions.Remove(_currentQuestion);

        if (_questions.Count == 0)
        {
            EndGame();
            return;
        }

        AdvanceToNextQuestion();
    }

    public void Pause()
    {
        _timer.Pause();
    }

    public void Resume()
    {
        _timer.Resume();
    }

    private void EndGame()
    {
        CalculateDiagnose();
        try { _timer.Dispose(); }
        catch
        {
            // ignored
        }

        UsersResultStorage.Append(_user);

        GameEnded?.Invoke(_user.Diagnose);
    }

    private void CalculateDiagnose()
    {
        _user.Diagnose = DiagnoseCalculator.Calculate(_questionCount, _user);
    }

    public string GetDiagnose()
    {
        CalculateDiagnose();
        try { _timer.Dispose(); }
        catch
        {
            // ignored
        }

        return _user.Diagnose;
    }

    public bool IsEnd()
    {
        return _questions.Count == 0;
    }
}