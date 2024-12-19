namespace Ynov.QuizYnov.Controllers.Dtos
{
    public class QuestionDto
    {
        public Guid Id { get; set; } 
        public string Text { get; set; } 
        public List<AnswerDto> Answers { get; set; }
    }
}
