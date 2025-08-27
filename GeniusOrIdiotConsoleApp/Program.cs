namespace GeniusOrIdiotConsoleApp;

internal static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Здравствуйте! Как вас зовут?");
        string userName = GetName();

        const int questionCount = 5;

        string[] questions = GetQuestions(questionCount);
        int[] answers = GetAnswers(questionCount);
        string[] diagnoses = GetDiagnoses();

        while (true)
        {
            Shuffle(questions, answers);

            var rightAnswersCount = 0;

            for (var i = 0; i < questionCount; i++)
            {
                int questionNumber = i + 1;

                Console.WriteLine($"{questionNumber}. {questions[i]}");

                int userAnswer;
                while (!int.TryParse(Console.ReadLine(), out userAnswer))
                {
                    PrintError("ОШИБКА: Пожалуйста, введите числовой ответ.");
                }

                if (userAnswer == answers[i])
                {
                    rightAnswersCount++;
                }
            }

            Console.WriteLine("Количество правильных ответов: " + rightAnswersCount);

            string diagnosis = GetDiagnosis(questionCount, rightAnswersCount);
            Console.WriteLine($"{userName}, Ваш диагноз: {diagnosis[rightAnswersCount]}");

            Console.WriteLine("Хотите пройти тест еще раз? (да/нет)");
            if (!IsRetryRequested())
            {
                break;
            }

            Console.Clear();
        }
    }

    private static string GetName()
    {
        while (true)
        {
            string? userName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(userName)) return userName;

            PrintError("ОШИБКА: Имя не может быть пустым. Пожалуйста, введите ваше имя.");
        }
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

    private static int[] GetAnswers(int questionCount)
    {
        var answers = new int[questionCount];

        answers[0] = 6;
        answers[1] = 9;
        answers[2] = 3;
        answers[3] = 25;
        answers[4] = 60;

        return answers;
    }

    private static string[] GetQuestions(int questionCount)
    {
        var questions = new string[questionCount];

        questions[0] = "Сколько будет два плюс два умноженное на два?";
        questions[1] = "Бревно нужно распилить на 10 частей. Сколько нужно сделать распилов?";
        questions[2] = "Пять свечей горело. Две потухли. Сколько свечей осталось?";
        questions[3] = "На двух руках 10 пальцев. Сколько пальцев на 5 руках?";
        questions[4] = "Укол делают каждые полчаса, сколько нужно минут для трёх уколов?";

        return questions;
    }

    private static void Shuffle(string[] questions, int[] answers)
    {
        var random = new Random();
        for (int i = questions.Length - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            (questions[i], questions[j]) = (questions[j], questions[i]);
            (answers[i], answers[j]) = (answers[j], answers[i]);
        }
    }

    private static bool IsRetryRequested()
    {
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

            PrintError("ОШИБКА: Пожалуйста, введите 'да' или 'нет'.");
        }
    }

    private static string GetDiagnosis(int questionCount, int rightAnswersCount)
    {
        var diagnoses = GetDiagnoses();
        int diagnosisCount = diagnoses.Length;

        if (diagnosisCount == 0)
            throw new InvalidOperationException("Список диагнозов пуст.");

        rightAnswersCount = Math.Clamp(rightAnswersCount, 0, questionCount);

        double range = (double)(questionCount + 1) / diagnosisCount;

        int index = (int)Math.Floor(rightAnswersCount / range);
        index = Math.Clamp(index, 0, diagnosisCount - 1);

        return diagnoses[index];
    }

    private static void PrintError(string message)
    {
        var previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = previousColor;
    }

    //private static void PrintError(string message,
    //    ConsoleColor color = ConsoleColor.Red)
    //{
    //    var previousColor = Console.ForegroundColor;
    //    Console.ForegroundColor = ConsoleColor.Red;
    //    Console.WriteLine(message);

    //    Console.ForegroundColor = previousColor;
    //}
}
