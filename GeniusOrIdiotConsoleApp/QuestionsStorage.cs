namespace GeniusOrIdiotConsoleApp;

internal class QuestionsStorage
{
    public static List<Question> GetAll()
    {
        List<Question> questions =
        [
            new Question("Сколько будет два плюс два умноженное на два?", 6),
            new Question("Бревно нужно распилить на 10 частей. Сколько нужно сделать распилов?", 9),
            new Question("Пять свечей горело. Две потухли. Сколько свечей осталось?", 3),
            new Question("Укол делают каждые полчаса, сколько нужно минут для трёх уколов?", 60),
            new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?", 25)
        ];

        return questions;
    }
}