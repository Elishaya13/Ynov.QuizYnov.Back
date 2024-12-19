using System.Text;
using Ynov.QuizYnov.Business.Models;
using Ynov.QuizYnov.Controllers.Dtos;

namespace Ynov.QuizYnov.Controllers.Mappers
{
    // QuizMapper prend un objet Quiz et le transforme en un QuizDto avec uniquement les données nécessaires pour l'API.
    public class QuizMapper
    {
        // Méthode ToDto sera de type QuizDto, prend en paramètre un quiz de type Quiz
        // Retourne un QuizDto crée avec les valeurs fournies du quiz: Id, Name, Description, Difficulty, Published, Category, Questions(List de Question)

        // Méthode pour convertir un Quiz en QuizDto
        public QuizDto ToDto(Quiz quiz)
        {
            return new QuizDto
            {
                Id = quiz.Id,
                Description = quiz.Description,
                Difficulty = quiz.Difficulty,
                Name = quiz.Name,
                Published = quiz.Published,
                Category = new CategoryDto
                {
                    Id = quiz.Category.Id,
                    Name = quiz.Category.Name
                },
                Questions = quiz.Questions?.Select(ToDto).ToList() ?? new List<QuestionDto>() // Réutilise ToDto pour chaque question
                //Questions = quiz.Questions?.Select(q => new QuestionDto
                //{
                //    Id = q.Id,
                //    Text = q.Text,
                //    Answers = q.Answers?.Select(a => new AnswerDto
                //    {
                //        Text = a.Text,
                //        IsCorrect = a.IsCorrect
                //    }).ToList() ?? new List<AnswerDto>() // Fournir une liste vide si q.Answers est null
                //}).ToList() ?? new List<QuestionDto>() // Fournir une liste vide si quiz.Questions est null

            };
        }
        // Méthode ppur convertir une Question en QuestionDTO
        public QuestionDto ToDto(Question question)
        {
            return new QuestionDto
            {
                Id = question.Id,
                Text = question.Text,
                Answers = question.Answers?.Select(a => new AnswerDto
                {
                    Text = a.Text,
                    IsCorrect = a.IsCorrect
                }).ToList() ?? new List<AnswerDto>() //Fournir une liste vide si q.Answers est null
            };
        }
    }
}
