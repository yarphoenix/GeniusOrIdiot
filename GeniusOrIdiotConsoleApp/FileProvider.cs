using System.Text;

namespace GeniusOrIdiotConsoleApp;

public static class FileProvider
{
    public static void Append(string fileName, string value)
    {
        using var writer = new StreamWriter(fileName, true, Encoding.UTF8);
        writer.WriteLine(value);
    }

    public static string GetValue(string fileName)
    {
        using var reader = new StreamReader(fileName, Encoding.UTF8);
        string value = reader.ReadToEnd();
        return value;
    }

    public static bool Exists(string fileName) => File.Exists(fileName);

    public static void Clear(string filePath) => File.WriteAllText(filePath, string.Empty);
}
