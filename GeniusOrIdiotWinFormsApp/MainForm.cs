using GeniusOrIdiotClassLibrary;

namespace GeniusOrIdiotWinFormsApp;

public partial class MainForm : Form
{
    private Game _game;

    public MainForm()
    {
        InitializeComponent();
        errorLabel.Visible = false;
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
        var welcomeForm = new WelcomeForm();
        welcomeForm.ShowDialog();

        var user = new User(welcomeForm.userNameInputTextBox.Text);
        _game = new Game(user);


        ShowNextQuestion();
    }

    private void ShowNextQuestion()
    {
        var currentQuestion = _game.GetNextQuestion();

        questionTextLabel.Text = currentQuestion.Text;

        string questionNumber = _game.GetQuestionNumberText();
        questionNumberLabel.Text = "Вопрос № " + questionNumber;
    }

    private void nextButton_Click(object sender, EventArgs e)
    {
        bool parsed = InputValidator.TryParseToNumber(userAnswerTextBox.Text, out int userAnswer, out string error);
        if (!parsed)
        {
            errorLabel.Visible = true;
            errorLabel.Text = error;
            return;
        }

        _game.AcceptAnswer(userAnswer);

        if (_game.IsEnd())
        {
            string diagnose = _game.GetDiagnose();
            MessageBox.Show(diagnose);
        }

        ShowNextQuestion();
        userAnswerTextBox.Clear();
    }

    private void ShowResultsToolMenuItem_Click(object sender, EventArgs e)
    {
        var resultsForm = new ResultsForm();
        resultsForm.ShowDialog();
    }

    private void RestartToolMenuItem_Click(object sender, EventArgs e)
    {
        Application.Restart();
    }

    private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void userAnswerTextBox_TextChanged(object sender, EventArgs e)
    {
        errorLabel.Visible = false;
    }

    private void userAnswerTextBox_Click(object sender, EventArgs e)
    {
        userAnswerTextBox.Clear();
    }

    private void QuestionManagerToolStripMenuItem_Click(object sender, EventArgs e)
    {
        var questionManager = new QuestionsManagerForm();
        questionManager.ShowDialog();
    }
}