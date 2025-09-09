namespace GeniusOrIdiotWinFormsApp;

public partial class WelcomeForm : Form
{
    public WelcomeForm()
    {
        InitializeComponent();
    }

    private void startButton_Click(object sender, EventArgs e)
    {
        Hide();
        var main = new GameForm();
        main.Closed += (s, args) => Close();
        main.Show();
    }

    private void QuestionManagerButton_Click(object sender, EventArgs e)
    {
        var manager = new QuestionsManagerForm();
        manager.ShowDialog();
    }
}