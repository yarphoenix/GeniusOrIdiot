namespace GeniusOrIdiotClassLibrary;

public static class UsersResultStorage
{
    private const string FileName = "UserResults.txt";

    public static void Save(User user)
    {
        var result = $"{user.Name}#{user.CorrectAnswerCount}#{user.Diagnose}";
        FileProvider.Append(FileName, result);
    }

    public static List<User> GetUserResults()
    {
        string value = FileProvider.GetValue(FileName);
        string[] lines = value.Split(['\n'], StringSplitOptions.RemoveEmptyEntries);

        var results = new List<User>();

        foreach (string line in lines)
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
}