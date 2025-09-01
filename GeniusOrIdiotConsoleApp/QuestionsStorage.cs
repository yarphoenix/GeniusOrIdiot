namespace GeniusOrIdiotConsoleApp;

public static class QuestionsStorage
{
    public static List<Question> GetAll()
    {
        var questions = new List<Question>();

        if (FileProvider.Exists("Questions.txt"))
        {
            string value = FileProvider.GetValue("Questions.txt");
            string[] lines = value.Split(['\n'], StringSplitOptions.RemoveEmptyEntries);
            foreach (string line in lines)
            {
                string[] parts = line.Split('#');
                string text = parts[0];
                int answer = int.Parse(parts[1]);

                var question = new Question(text, answer);
                questions.Add(question);
            }
        }
        else
        {
            questions.Add(new Question("Сколько будет два плюс два умноженное на два?", 6));
            questions.Add(new Question("Бревно нужно распилить на 10 частей. Сколько нужно сделать распилов?", 9));
            questions.Add(new Question("Пять свечей горело. Две потухли. Сколько свечей осталось?", 3));
            questions.Add(new Question("Укол делают каждые полчаса, сколько нужно минут для трёх уколов?", 60));
            questions.Add(new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25));
            SaveQuestions(questions);
        }

        return questions;
    }

    public static void Add(Question newQuestion)
    {
        var value = $"{newQuestion.Text}#{newQuestion.Answer}";
        FileProvider.Append("Questions.txt", value);
    }

    public static void Remove(Question question)
    {
        var questions = GetAll();
        for (var i = 0; i < questions.Count; i++)
        {
            if (questions[i].Text == question.Text)
            {
                questions.RemoveAt(i);
                break;
            }
        }
        FileProvider.Clear("Questions.txt");
        SaveQuestions(questions);
    }

    private static void SaveQuestions(List<Question> questions)
    {
        foreach (var question in questions)
        {
            Add(question);
        }
    }
}