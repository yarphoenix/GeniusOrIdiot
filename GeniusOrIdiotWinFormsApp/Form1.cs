using GeniusOrIdiotConsoleApp;

namespace GeniusOrIdiotWinFormsApp
{
    public partial class GeniusOrIdiot : Form
    {
        public GeniusOrIdiot()
        {
            InitializeComponent();
        }

        private void GeniusOrIdiot_Load(object sender, EventArgs e)
        {
            var questions = QuestionsStorage.GetAll();
        }

        private void questionNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void questionTextLabel_Click(object sender, EventArgs e)
        {

        }

        private void userAnswerTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {

        }
    }
}
