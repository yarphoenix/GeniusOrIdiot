namespace GeniusOrIdiotConsoleApp;

public static class DiagnoseCalculator
{
    public static string Calculate(int questionCount, User user)
    {
        var diagnoses = new List<string> { "Идиот", "Кретин", "Дурак", "Нормальный", "Талант", "Гений" };
        int percentage = user.CorrectAnswerCount * 100 / questionCount;

        return diagnoses[percentage / 20];
    }
}
