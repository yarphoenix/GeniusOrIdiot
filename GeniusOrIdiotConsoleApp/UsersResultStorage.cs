using System.Text;

namespace GeniusOrIdiotConsoleApp
{
    internal class UsersResultStorage
    {
        public static void Save(User user)
        {
            var result = $"{user.Name}#{user.CorrectAnswerCount}#{user.Diagnose}";
            AppendToFile("UserResults.txt", result);
        }

        public static int GetUserAnswer()
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

        public static List<User> GetUserResults()
        {
            const string fileName = "UserResults.txt";

            var results = new List<User>();

            using var reader = new StreamReader(fileName, Encoding.UTF8);
            while (reader.ReadLine() is { } line)
            {
                string[] values = line.Split('#');
                string name = values[0];
                int correctAnswerCount = int.Parse(values[1]);
                string diagnose = values[2];

                var user = new User(name)
                {
                    CorrectAnswerCount = correctAnswerCount,
                    Diagnose = diagnose
                };

                results.Add(user);
            }

            return results;
        }

        private static void AppendToFile(string fileName, string value)
        {
            using var writer = new StreamWriter(fileName, true, Encoding.UTF8);
            writer.WriteLine(value);
        }
    }
}
