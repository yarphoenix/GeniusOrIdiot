using GeniusOrIdiotClassLibrary;

namespace GeniusOrIdiotWinFormsApp;

public partial class ResultsForm : Form
{
    public ResultsForm()
    {
        InitializeComponent();
    }

    private void ResultsForm_Load(object sender, EventArgs e)
    {
        var results = UsersResultStorage.GetUserResults();
        foreach (var result in results)
        {
            resultsGridView.Rows.Add(result.Name, result.CorrectAnswerCount, result.Diagnose);
        }
    }
}