using GeniusOrIdiotClassLibrary;

namespace GeniusOrIdiotWinFormsApp
{
    public partial class QuestionsManagerForm : Form
    {
        public QuestionsManagerForm()
        {
            InitializeComponent();
        }

        private void QuestionsManagerForm_Load(object sender, EventArgs e)
        {
            var questions = QuestionsStorage.GetAll();
            foreach (var question in questions)
            {
                QuestionsGridView.Rows.Add(question.Text, question.Answer);
            }
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
    }
}
