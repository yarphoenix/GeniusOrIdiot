using GeniusOrIdiotConsoleApp;

namespace GeniusOrIdiotWinFormsApp
{
    public partial class MainForm : Form
    {
        private List<Question> _questions;
        private Question _currentQuestion;
        private int _currentQuestionNumber;
        private int _questionCount;
        private User _user;

        public MainForm()
        {
            InitializeComponent();
        }

        private void GeniusOrIdiot_Load(object sender, EventArgs e)
        {
            _questions = QuestionsStorage.GetAll();
            _questionCount = _questions.Count;
            _currentQuestionNumber = 0;
            _user = new User();

            ShowNextQuestion();
        }

        private void ShowNextQuestion()
        {
            var random = new Random();
            int nextQuestionIndex = random.Next(0, _questions.Count);

            _currentQuestion = _questions[nextQuestionIndex];

            questionTextLabel.Text = _currentQuestion.Text;

            _currentQuestionNumber++;
            questionNumberLabel.Text = "Вопрос № " + _currentQuestionNumber;
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
            var userAnswer = Convert.ToInt32(userAnswerTextBox.Text);
            int rightAnswer = _currentQuestion.Answer;
            if (userAnswer == rightAnswer)
            {
                _user.AcceptRightAnswer();
            }
            _questions.Remove(_currentQuestion);

            bool endGame = _questions.Count == 0;
            if (endGame)
            {
                _user.Diagnose = DiagnoseCalculator.Calculate(_questionCount, _user);
                MessageBox.Show(_user.Diagnose);
            }

            ShowNextQuestion();
        }
    }
}
