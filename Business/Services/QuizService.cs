using Ynov.QuizYnov.Business.Models;

namespace Ynov.QuizYnov.Business.Services
{
    public class QuizService : IQuizService
    {
        private List<Quiz> _quizList = new List<Quiz>
        {
            new Quiz
            {
               
                Id = new Guid("aa17e21e-4254-4738-9d3d-33df27c2747a"),
                Category = new Category() {Id = 1, Name = "Développement Back-end"},
                Description = "Viens tester tes connaissances appronfondie en ASP.NET Core",
                Difficulty = 3,
                Name = "Défi ASP.NET Core",
                Published = new DateTime(2024,11,25,10,57,10),
                Questions = new List<Question>
                {
                    new Question
                    {
                        Id = new Guid("2c93bc60-557d-4853-8bfc-33217e42b0f9"),
                        Text= "Quelle méthode est utilisée pour configurer les middlewares dans ASP.NET Core ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "ConfigureService", IsCorrect = false},
                            new Answer { Text = "Configure", IsCorrect= true},
                            new Answer {Text = "Main", IsCorrect= false}    
                        }
                    },
                    new Question
                    {
                        Id = new Guid("a1b2c3d4-e5f6-7890-abcd-123456789abc"),
                        Text = "Quelle interface est utilisée pour injecter un service de logging dans ASP.NET Core ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "ILogger", IsCorrect = true },
                            new Answer { Text = "IServiceProvider", IsCorrect = false },
                            new Answer { Text = "IHost", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = new Guid("b2c3d4e5-f678-90ab-cdef-123456789abc"),
                        Text = "Quelle commande CLI est utilisée pour créer un nouveau projet ASP.NET Core MVC ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "dotnet new mvc", IsCorrect = true },
                            new Answer { Text = "dotnet new webapi", IsCorrect = false },
                            new Answer { Text = "dotnet build mvc", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = new Guid("c3d4e5f6-7890-abcd-ef12-34567890abcd"),
                        Text = "Quelle classe est utilisée pour configurer les services et le pipeline HTTP dans ASP.NET Core ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "Startup", IsCorrect = true },
                            new Answer { Text = "Program", IsCorrect = false },
                            new Answer { Text = "Host", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = new Guid("d4e5f678-90ab-cdef-1234-567890abcdef"),
                        Text = "Quel middleware ASP.NET Core est utilisé pour gérer les erreurs globales ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "UseExceptionHandler", IsCorrect = true },
                            new Answer { Text = "UseDeveloperExceptionPage", IsCorrect = false },
                            new Answer { Text = "UseRouting", IsCorrect = false }
                        }
                    }

                }
                
            },
            new Quiz
            {
                Id = new Guid("beb83ab9-a777-4b9e-8057-966f1d58e80e"),
                Category = new Category() {Id = 2, Name = "Développement Front-end"},
                Description = "Test de connaissances sur CSS",
                Difficulty = 1,
                Name = "CSS pour débutant",
                Published = new DateTime(2023, 01, 20, 10, 57, 10),
                Questions = new List<Question>
                {
                    new Question
                    {
                        Id = new Guid("078418d2-a83e-4f4c-9641-3ecc6c813b15"),
                        Text = "Quelle propriété CSS est utilisée pour définir la couleur du texte ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "color", IsCorrect = true },
                            new Answer { Text = "background-color", IsCorrect = false },
                            new Answer { Text = "text-color", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = new Guid("e2c83332-40af-40ba-a736-6faf82f0572c"),
                        Text = "Quel préprocesseur CSS permet d'utiliser des variables ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "Sass", IsCorrect = true },
                            new Answer { Text = "Bootstrap", IsCorrect = false },
                            new Answer { Text = "Normalize.css", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = new Guid("f2d12345-a1b2-4c3d-8e9f-123456789abc"),
                        Text = "Quelle propriété CSS est utilisée pour définir l'espacement intérieur d'un élément ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "padding", IsCorrect = true },
                            new Answer { Text = "margin", IsCorrect = false },
                            new Answer { Text = "border", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = new Guid("a1d2b3c4-d4e5-f678-90ab-cdef12345678"),
                        Text = "Quel est l'ordre des valeurs dans la propriété CSS shorthand pour 'margin' ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "haut, droite, bas, gauche", IsCorrect = true },
                            new Answer { Text = "haut, gauche, bas, droite", IsCorrect = false },
                            new Answer { Text = "gauche, haut, droite, bas", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = new Guid("b3c4d5e6-f789-0123-4567-89abcdef0123"),
                        Text = "Quelle propriété CSS contrôle l'ordre des éléments dans un conteneur Flexbox ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "order", IsCorrect = true },
                            new Answer { Text = "z-index", IsCorrect = false },
                            new Answer { Text = "flex-direction", IsCorrect = false }
                        }
                    }
                }
            },
            new Quiz
            {
                Id = new Guid("ab28e223-d8b7-49a6-81ef-99d3c2749d3b"),
                Category = new Category() { Id = 2, Name = "Développement Front-end" },
                Description = "Découvre à quel point tu maîtrises CSS et ses subtilités.",
                Difficulty = 2,
                Name = "CSS Intermediaire",
                Published = new DateTime(2023, 02, 10, 15, 30, 00),
                Questions = new List<Question>
                {
                    new Question
                    {
                        Id = new Guid("de12ab34-cf98-4a72-bd9f-12e83ac3c111"),
                        Text = "Quel unité CSS est relative à la taille de la police de l'élément parent ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "px", IsCorrect = false },
                            new Answer { Text = "em", IsCorrect = true },
                            new Answer { Text = "rem", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = new Guid("a912ed38-c6af-4bf7-bd3e-91fb0d32b999"),
                        Text = "Quelle propriété CSS est utilisée pour rendre un élément flexible dans une boîte flexbox ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "flex-grow", IsCorrect = true },
                            new Answer { Text = "flex-shrink", IsCorrect = false },
                            new Answer { Text = "align-items", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = new Guid("bb65a8c1-f23b-4d43-8e6d-12cd3e8d0a1f"),
                        Text = "Comment centrer un élément horizontalement et verticalement dans une div en utilisant Flexbox ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "justify-content: center; align-items: center;", IsCorrect = true },
                            new Answer { Text = "display: block; margin: auto;", IsCorrect = false },
                            new Answer { Text = "text-align: center; vertical-align: middle;", IsCorrect = false }
                        }
                    }
                }
            },
            new Quiz
            {
                Id = new Guid("e4165ac1-039a-4f8f-9ed2-aac321b4b084"),
                Category = new Category() { Id = 2, Name = "Développement Front-end" },
                Description = "Évalue tes connaissances en JavaScript, des bases aux concepts avancés.",
                Difficulty = 2,
                Name = "Défi JavaScript",
                Published = new DateTime(2023, 03, 15, 14, 45, 00),
                Questions = new List<Question>
                {
                    new Question
                    {
                        Id = new Guid("6da3cc98-fff6-4a00-a064-c3e805b94880"),
                        Text = "Quel mot-clé est utilisé pour déclarer une variable qui ne peut pas être réassignée ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "let", IsCorrect = false },
                            new Answer { Text = "const", IsCorrect = true },
                            new Answer { Text = "var", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = new Guid("1ce305e5-6806-447f-a7c3-7c693337b05b"),
                        Text = "Quelle méthode est utilisée pour convertir un objet JSON en chaîne de caractères  ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "JSON.parse()", IsCorrect = false },
                            new Answer { Text = "JSON.stringify()", IsCorrect = true },
                            new Answer { Text = "JSON.convert()", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = new Guid("b724b53c-f23a-4f1d-8641-fccb2639a33e"),
                        Text = "Que renvoie l'expression `typeof null` en JavaScript ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "null", IsCorrect = false },
                            new Answer { Text = "object", IsCorrect = true },
                            new Answer { Text = "undefined", IsCorrect = false }
                        }
                    },
                     new Question
                    {
                        Id = new Guid("ebf9a233-3c12-4a07-b781-f1d7832f016e"),
                        Text = "Comment déclarer une fonction fléchée en JavaScript ?",
                        Answers = new List<Answer>
                        {
                           new Answer { Text = "`const myFunc = () => {}`", IsCorrect = true },
                           new Answer { Text = "`function myFunc() {}`", IsCorrect = false },
                           new Answer { Text = "`let myFunc = function() {}`", IsCorrect = false }
                        }
                    },
                      new Question
                    {
                        Id = new Guid("1ce305e5-6806-447f-a7c3-7c693337b05b"),
                        Text = "Quelle est la sortie de `console.log(1 + '1')` en JavaScript ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "2", IsCorrect = false },
                            new Answer { Text = "11", IsCorrect = true },
                            new Answer { Text = "undefined", IsCorrect = false }
                        }
                    }
                }
            },
            new Quiz
            {
                Id = new Guid("a0b1c2d3-e4f5-6789-1011-121314151617"),
                Category = new Category() { Id = 3, Name = "Culture Générale en Développement" },
                Description = "Testez vos connaissances sur l'histoire du développement informatique, des technologies marquantes aux figures emblématiques du domaine.",
                Difficulty = 2,
                Name = "Horizons du Développement",
                Published = new DateTime(2025, 01, 15, 10, 00, 00),
                Questions = new List<Question>
                {
                    new Question
                    {
                        Id = new Guid("12345678-90ab-cdef-1011-121314151617"),
                        Text = "Qui est connu comme le père de l'informatique moderne ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "Alan Turing", IsCorrect = true },
                            new Answer { Text = "Bill Gates", IsCorrect = false },
                            new Answer { Text = "Steve Jobs", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = new Guid("23456789-01ab-cdef-1011-121314151617"),
                        Text = "Quelle année marque le lancement du premier site web ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "1983", IsCorrect = false },
                            new Answer { Text = "1991", IsCorrect = true },
                            new Answer { Text = "1998", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = new Guid("34567890-12ab-cdef-1011-121314151617"),
                        Text = "Quel langage de programmation est considéré comme le plus ancien encore utilisé aujourd'hui ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "COBOL", IsCorrect = true },
                            new Answer { Text = "C", IsCorrect = false },
                            new Answer { Text = "Java", IsCorrect = false }
                        }
                    },
                    new Question
                    {
                        Id = new Guid("45678901-23ab-cdef-1011-121314151617"),
                        Text = "Quel projet est le premier logiciel open-source ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "GNU", IsCorrect = false },
                            new Answer { Text = "Linux", IsCorrect = false },
                            new Answer { Text = "Netscape Navigator", IsCorrect = true }
                        }
                    },
                    new Question
                    {
                        Id = new Guid("56789012-34ab-cdef-1011-121314151617"),
                        Text = "Qui a inventé le premier compilateur ?",
                        Answers = new List<Answer>
                        {
                            new Answer { Text = "Grace Hopper", IsCorrect = true },
                            new Answer { Text = "Ada Lovelace", IsCorrect = false },
                            new Answer { Text = "Margaret Hamilton", IsCorrect = false }
                        }
                    }
                }
            }

        };

        public IEnumerable<Quiz> GetAll()
        {
            return _quizList;
        }

        public Quiz? GetById(Guid id)
        {
            return _quizList.Find(quiz => quiz.Id == id);
        }

        public IEnumerable<Question>? GetQuestionsByQuizId(Guid id)
        {
            // FirstOrDefault = Retourne le premier élément d'une séquence ou une valeur par défaut si aucun élément n'est trouvé.
            // Trouve le quiz correspondant à l'Id
            var quiz = _quizList.FirstOrDefault(quiz => quiz.Id == id);

            //Si le quiz existe, retourne les questions, sinon retourn null
            return quiz?.Questions;
        }
    }
}
