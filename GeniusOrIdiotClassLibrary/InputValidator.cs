namespace GeniusOrIdiotClassLibrary;

public static class InputValidator
{
    public static bool TryParseToNumber(string input, out int number, out string error)
    {
        try
        {
            number = int.Parse(input);
            error = string.Empty;
            return true;
        }
        catch (FormatException)
        {
            number = 0;
            error = "Введено нечисловое значение";
            return false;
        }
        catch (OverflowException)
        {
            number = 0;
            error = "Введенное число слишком большое";
            return false;
        }
    }
}