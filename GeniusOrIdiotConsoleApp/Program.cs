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

            string diagnose = DiagnoseCalculator.Calculate(questionCount, user);
            user.Diagnose = diagnose;
            Console.WriteLine($"{user.Name}, Ваш диагноз: {diagnose}");

            UsersResultStorage.Save(user);

            bool userChoice = GetUserChoice("Хотите посмотреть предыдущие результаты игры?");
            if (userChoice)
                ShowUserResults();

            userChoice = GetUserChoice("Хотите добавить новый вопрос?");
            if (userChoice)
                AddNewQuestion();

            userChoice = GetUserChoice("Хотите удалить вопрос?");
            if (userChoice)
                RemoveQuestion();

            userChoice = GetUserChoice("Хотите начать сначала?");
            if (!userChoice)
                break;

            Console.Clear();
        }
    }

    private static void RemoveQuestion()
    {
        var questions = QuestionsStorage.GetAll();
        Console.WriteLine("Введите индекс вопроса для удаления (от 1 до " + questions.Count + "):");
        for (var i = 0; i < questions.Count; i++)
        {
            Console.WriteLine(i + 1 + ": " + questions[i].Text);
        }
        int index = GetUserAnswer();
        while (index < 1 || index > questions.Count)
        {
            MessagePrinter.Print("ОШИБКА: Некорректный индекс вопроса. Пожалуйста, попробуйте снова.", ConsoleColor.Red);
            index = GetUserAnswer();
        }

        QuestionsStorage.Remove(questions[index + 1]);
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
