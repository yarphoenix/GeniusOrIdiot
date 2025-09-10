using GeniusOrIdiotClassLibrary;

namespace GeniusOrIdiotWinFormsApp
{
    public partial class QuestionsManagerForm : Form
    {
        private const string DefaultQuestionPlaceholder = "Введите текст";

        public QuestionsManagerForm()
        {
            InitializeComponent();
            ErrorLabel.Visible = false;
        }

        private void QuestionsManagerForm_Load(object sender, EventArgs e)
        {
            var questions = QuestionsStorage.GetAll();
            foreach (var question in questions)
            {
                QuestionsGridView.Rows.Add(question.Text, question.Answer);
            }
        }

        private void AddQuestionButton_Click(object sender, EventArgs e)
        {
            if (!TryValidateQuestionInput(out string questionText, out int questionAnswer, out string errorMessage))
            {
                ErrorLabel.Visible = true;
                ErrorLabel.Text = errorMessage;
                return;
            }

            var question = new Question(questionText, questionAnswer);

            QuestionsStorage.Add(question);
            QuestionsGridView.Rows.Add(question.Text, question.Answer);
            ShowOperationSuccess("Вопрос успешно добавлен!");
            ErrorLabel.Visible = false;
        }

        private void DeleteQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (QuestionsGridView.CurrentRow == null)
                return;

            string text = QuestionsGridView.CurrentRow.Cells[0].Value?.ToString() ?? string.Empty;
            int.TryParse(QuestionsGridView.CurrentRow.Cells[1].Value?.ToString(), out int answer);

            var question = new Question(text, answer);

            if (!ConfirmDeleteQuestion(question))
                return;

            QuestionsStorage.Remove(question);
            QuestionsGridView.Rows.Remove(QuestionsGridView.CurrentRow);
            ShowOperationSuccess("Вопрос успешно удалён!");
        }

        private bool TryValidateQuestionInput(out string questionText, out int questionAnswer, out string errorMessage)
        {
            questionText = QuestionTextBox.Text;
            errorMessage = string.Empty;
            questionAnswer = 0;

            if (questionText == DefaultQuestionPlaceholder)
            {
                errorMessage = "Введите текст вопроса.";
                return false;
            }

            if (AnswerTextBox.TextLength == 0)
            {
                errorMessage = "Введите числовой ответ на вопрос.";
                return false;
            }

            if (!InputValidator.TryParseToNumber(AnswerTextBox.Text, out questionAnswer, out errorMessage))
            {
                return false;
            }

            return true;
        }

        private void QuestionTextBox_Enter(object sender, EventArgs e)
        {
            if (QuestionTextBox.Text == DefaultQuestionPlaceholder)
            {
                QuestionTextBox.Text = string.Empty;
                QuestionTextBox.ForeColor = Color.Black;
            }

            ErrorLabel.Visible = false;
        }

        private void QuestionTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(QuestionTextBox.Text))
            {
                QuestionTextBox.Text = DefaultQuestionPlaceholder;
                QuestionTextBox.ForeColor = Color.Gray;
            }
        }

        private void AnswerTextBox_Click(object sender, EventArgs e)
        {
            ErrorLabel.Visible = false;
        }

        private static bool ConfirmDeleteQuestion(Question question)
        {
            return MessageBox.Show(
                $"""
                 Вы действительно хотите удалить вопрос?
                 Текст: {question.Text}
                 """,
                @"Подтверждение удаления",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            ) == DialogResult.Yes;
        }

        private static void ShowOperationSuccess(string message)
        {
            MessageBox.Show(
                message,
                @"Операция выполнена",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}