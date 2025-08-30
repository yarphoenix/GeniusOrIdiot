namespace GeniusOrIdiotConsoleApp;

internal static class MessagePrinter
{
    public static void Print(string message) => Console.WriteLine("ОШИБКА: " + message);

    public static void Print(string message, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.WriteLine("ОШИБКА: " + message);
        Console.ResetColor();
    }
}