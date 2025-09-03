namespace GeniusOrIdiotClassLibrary;

public class User(string name = "Неизвестно")
{
    public string Name { get; } = name;
    public int CorrectAnswerCount { get; set; }
    public string Diagnose { get; set; } = "Неизвестно";

    public void AcceptRightAnswer() => CorrectAnswerCount++;
}