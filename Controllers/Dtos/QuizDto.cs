namespace Ynov.QuizYnov.Controllers.Dtos
{
    public class QuizDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description {  get; set; }

        public int Difficulty {  get; set; }

        public DateTime Published { get; set; }

        public CategoryDto Category {  get; set; }


        public List<QuestionDto> Questions { get; set; }
    }
}
