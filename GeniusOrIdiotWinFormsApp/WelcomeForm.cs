namespace GeniusOrIdiotWinFormsApp;

public partial class WelcomeForm : Form
{
    public WelcomeForm()
    {
        InitializeComponent();

        FormClosing += WelcomeForm_FormClosing;
    }

    private void startButton_Click(object sender, EventArgs e)
    {
        FormClosing -= WelcomeForm_FormClosing;
        Close();
    }

    private static void WelcomeForm_FormClosing(object sender, EventArgs e)
    {
        Application.Exit();
    }
}