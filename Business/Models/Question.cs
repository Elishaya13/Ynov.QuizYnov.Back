namespace Ynov.QuizYnov.Business.Models
{
    public class Question
    {
        public Guid Id { get; set; }
        public string Text { get; set; }

        public List<Answer> Answers { get; set; } = new List<Answer>();
    }
}
