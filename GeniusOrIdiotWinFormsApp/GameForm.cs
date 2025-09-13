using GeniusOrIdiotClassLibrary;

namespace GeniusOrIdiotWinFormsApp;

public partial class GameForm : Form
{
    private Game _game;

    public GameForm()
    {
        InitializeComponent();
        errorLabel.Visible = false;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        var user = new User(WelcomeForm.userNameInputTextBox.Text);
        _game = new Game(user);

        _game.Tick += OnTick;
        _game.QuestionChanged += OnQuestionChanged;
        _game.GameEnded += OnGameEnded;

        _game.GetNextQuestion();
    }

    private void OnTick(int seconds)
    {
        ChangeRemainingTimeLabelColor(seconds);
        RemainingTimeLabel.Text = "Времени осталось: " + seconds;
    }

    private void OnQuestionChanged(Question question)
    {
        questionTextLabel.Text = question.Text;
        questionNumberLabel.Text = "Вопрос № " + _game.GetQuestionNumberText();
        userAnswerTextBox.Clear();
        errorLabel.Visible = false;
    }

    private void OnGameEnded(string diagnose)
    {
        MessageBox.Show(diagnose);
    }

    private void NextButton_Click(object sender, EventArgs e)
    {
        bool parsed = InputValidator.TryParseToNumber(userAnswerTextBox.Text, out int userAnswer, out string error);
        if (!parsed)
        {
            errorLabel.Visible = true;
            errorLabel.Text = error;
            return;
        }

        _game.AcceptAnswer(userAnswer);
    }

    private void ShowResultsToolMenuItem_Click(object sender, EventArgs e)
    {
        _game.Pause();

        var resultsForm = new ResultsForm();
        resultsForm.ShowDialog();

        _game.Resume();
    }

    private void ChangeRemainingTimeLabelColor(int seconds)
    {
        var colors = new List<Color>
        {
            Color.Red,
            Color.Orange,
            Color.Green,
        };

        double intervalLength = (double)10 / colors.Count;

        var index = (int)(seconds / intervalLength);

        if (index >= colors.Count)
            index = colors.Count - 1;

        RemainingTimeLabel.ForeColor = colors[index];
    }

    private void RestartToolMenuItem_Click(object sender, EventArgs e)
    {
        Application.Restart();
    }

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        base.OnFormClosing(e);

        _game.Tick -= OnTick;
        _game.QuestionChanged -= OnQuestionChanged;
        _game.GameEnded -= OnGameEnded;
    }


}