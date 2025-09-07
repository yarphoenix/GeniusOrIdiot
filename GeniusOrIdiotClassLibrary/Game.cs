namespace GeniusOrIdiotClassLibrary;
public class Game
{
    private readonly User _user;
    private readonly List<Question> _questions;

    private Question _currentQuestion;
    private int _currentQuestionNumber;
    private int _questionCount;

    public Game(User user)
    {
        _user = user;
        _questions = QuestionsStorage.GetAll();
        _questionCount = _questions.Count;
    }

    public Question GetNextQuestion()
    {
        var random = new Random();
        int nextQuestionIndex = random.Next(0, _questions.Count);

        _currentQuestionNumber++;

        _currentQuestion = _questions[nextQuestionIndex];
        return _currentQuestion;
    }

    public string GetQuestionNumberText()
    {
        return _currentQuestionNumber.ToString();
    }

    public void AcceptAnswer(int userAnswer)
    {
        int rightAnswer = _currentQuestion.Answer;
        if (userAnswer == rightAnswer)
        {
            _user.AcceptRightAnswer();
        }
        _questions.Remove(_currentQuestion);
    }

    public bool IsEnd()
    {
        return _questions.Count == 0;
    }

    public string GetDiagnose()
    {
        CalculateDiagnose();
        return _user.Diagnose;
    }

    private void CalculateDiagnose()
    {
        _user.Diagnose = DiagnoseCalculator.Calculate(_questionCount, _user);

        UsersResultStorage.Save(_user);
    }
}