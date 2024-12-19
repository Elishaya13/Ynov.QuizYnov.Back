using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Ynov.QuizYnov.Business;
using Ynov.QuizYnov.Business.Models;
using Ynov.QuizYnov.Controllers.Dtos;
using Ynov.QuizYnov.Controllers.Mappers;

namespace Ynov.QuizYnov.Controllers
{
    [Route("api/quizzes")]
    [ApiController]
    public class QuizController : ControllerBase
    {
        private readonly IQuizService _service;
        private readonly QuizMapper _mapper;

        public QuizController(IQuizService service, QuizMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        [HttpGet(Name = "GetAllQuiz")]
        [ProducesResponseType(typeof(IEnumerable<QuizDto>), 200)]
        public IActionResult GetAll()
        {
            IEnumerable<Quiz> quizList = _service.GetAll();

            if (!quizList.Any())
            {
                return NoContent(); // Retourne 204 si aucun quiz n'est disponible
            }

            IEnumerable<QuizDto> quizDtoList = quizList.Select(quiz => _mapper.ToDto(quiz));

            return Ok(quizDtoList);
        }

        [HttpGet("{id}", Name = "GetById")]
        [ProducesResponseType(typeof(QuizDto), 200)]
        public IActionResult GetById(Guid id)
        {
            Quiz? quiz = _service.GetById(id);

            if (quiz == null)
            {
                return NotFound();
            }
            else
            {
                QuizDto quizDto = _mapper.ToDto(quiz);
                return Ok(quizDto);
            }

        }

        // Route pour récuperer les questions d'un quizz "api/quizzes/{id}/questions
        [HttpGet("{id}/questions", Name ="GetQuestionsByQuizId")]
        [ProducesResponseType(typeof(IEnumerable<QuestionDto>), 200)]

        public IActionResult GetQuestionsByQuizId(Guid id)
        {
            // Vérifier sur le quiz existe avec l'id, si non retourner 404 not found
            Quiz? quiz = _service.GetById(id);
            if (quiz == null)
            {
                return NotFound();
            }
           
            // Récuperer les questions du quiz
            var questions = _service.GetQuestionsByQuizId(id);

            //Vérifier s'il y a des questions
            if (questions == null || !questions.Any())
            {
                return NoContent(); // Retourn 204 si le quiz n'a pas de questions
            }

            // Mapper les questions en DTO
            var questionsDtos = questions.Select(question => _mapper.ToDto(question)).ToList();
            
            return Ok(questionsDtos);

           
        }

    }
}
