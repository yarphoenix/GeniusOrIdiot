namespace GeniusOrIdiotConsoleApp;

internal static class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Здравствуйте! Как вас зовут?");
            string? userName = Console.ReadLine();
            var user = new User(userName);
            var questions = QuestionsStorage.GetAll();
            int questionCount = questions.Count;

            var random = new Random();

            for (var i = 0; i < questionCount; i++)
            {
                Console.WriteLine("Вопрос " + (i + 1));
                int nextQuestionIndex = random.Next(0, questions.Count);
                Console.WriteLine(questions[nextQuestionIndex].Text);

                int userAnswer = GetUserAnswer();
                int rightAnswer = questions[nextQuestionIndex].Answer;

                if (userAnswer == rightAnswer)
                    user.AcceptRightAnswer();

                questions.RemoveAt(nextQuestionIndex);
            }

            Console.WriteLine("Количество правильных ответов: " + user.CorrectAnswerCount);

            string diagnose = CalculateDiagnose(questionCount, user.CorrectAnswerCount);
            user.Diagnose = diagnose;
            Console.WriteLine($"{user.Name}, Ваш диагноз: {diagnose}");

            UsersResultStorage.Save(user);

            bool userChoice = GetUserChoice("Хотите посмотреть предыдущие результаты игры?");
            if (userChoice)
                ShowUserResults();

            userChoice = GetUserChoice("Хотите добавить новый вопрос?");
            if (userChoice)
                AddNewQuestion();

            userChoice = GetUserChoice("Хотите начать сначала?");
            if (!userChoice)
                break;

            Console.Clear();
        }
    }

    private static void AddNewQuestion()
    {
        Console.WriteLine("Введите текст вопроса:");
        string? text = Console.ReadLine();
        Console.WriteLine("Введите числовой ответ на вопрос:");
        int answer = GetUserAnswer();

        var question = new Question(text, answer);
        QuestionsStorage.Add(question);
    }

    private static int GetUserAnswer()
    {
        while (true)
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                MessagePrinter.Print("ОШИБКА: Пожалуйста, введите числовой ответ.", ConsoleColor.Red);
            }
            catch (OverflowException)
            {
                MessagePrinter.Print("ОШИБКА: Введенное число слишком большое или слишком маленькое.", ConsoleColor.Red);
            }
        }
    }

    private static string CalculateDiagnose(int questionCount, int correctAnswersCount)
    {
        string[] diagnoses = GetDiagnoses();

        int correctAnswersPercent = correctAnswersCount * 100 / questionCount;

        return diagnoses[correctAnswersPercent / 20];
    }

    private static string[] GetDiagnoses()
    {
        var diagnosis = new[]
        {
            "Идиот",
            "Кретин",
            "Дурак",
            "Нормальный",
            "Талант",
            "Гений"
        };

        return diagnosis;
    }

    private static bool GetUserChoice(string message)
    {
        Console.WriteLine(message + " (да/нет)");

        while (true)
        {
            string? response = Console.ReadLine();

            if (string.Equals(response, "да", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (string.Equals(response, "нет", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }

            MessagePrinter.Print("ОШИБКА: Пожалуйста, введите 'да' или 'нет'.", ConsoleColor.Red);
        }
    }

    private static void ShowUserResults()
    {
        Console.WriteLine("{0, -20}{1, 18}{2, 15}", "Имя", "Кол-во правильных ответов", "Диагноз");

        var results = UsersResultStorage.GetUserResults();
        foreach (var user in results)
        {
            Console.WriteLine("{0, -20}{1, 18}{2, 15}", user.Name, user.CorrectAnswerCount, user.Diagnose);
        }
    }
}
