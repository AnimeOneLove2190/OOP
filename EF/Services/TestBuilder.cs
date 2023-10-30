using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.EntitiesTestDB;
using EFVaiaa.DTOTestDB1;
using System.Linq;
using EFVaiaa.Interfaces;

namespace EFVaiaa.Services
{
    class TestBuilder : ITestBuilder
    {
        public int CreateQuestionAndGetId(QuestBuilderCreate questBuilder)
        {
            if (questBuilder == null)
            {
                throw new Exception("CreateQuestionAndGetId: One or more input parameters contain null");
            }
            if (string.IsNullOrEmpty(questBuilder.Name))
            {
                throw new Exception("CreateQuestionAndGetId: Name field is required");
            }
            if (string.IsNullOrEmpty(questBuilder.Description))
            {
                throw new Exception("CreateQuestionAndGetId: Description field is required");
            }
            if (questBuilder.TestId <= 0)
            {
                throw new Exception("CreateQuestionAndGetId: TestId field must not be empty or contain a negative value");
            }
            if (questBuilder.PossibleAnswers == null)
            {
                throw new Exception("CreateQuestionAndGetId: The collection of possible answers cannot be empty");
            }
            if (questBuilder.PossibleAnswers.Count == 1)
            {
                throw new Exception("CreateQuestionAndGetId: The collection of possible answers cannot contain only one possible answer");
            }
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var possibleAnswers = new List<PossibleAnswer>();
                for (int i = 0; i < questBuilder.PossibleAnswers.Count; i++)
                {
                    var possibleAnswer = new PossibleAnswer
                    {
                        Id = questBuilder.PossibleAnswers[i].Id,
                        Name = questBuilder.PossibleAnswers[i].Name,
                        IsRight = questBuilder.PossibleAnswers[i].IsRight,
                        QuestionId = questBuilder.PossibleAnswers[i].QuestionId,
                    };
                    possibleAnswers.Add(possibleAnswer);
                }
                var question = new Question
                {
                    Name = questBuilder.Name,
                    Description = questBuilder.Description,
                    TestId = questBuilder.TestId,
                    PossibleAnswers = possibleAnswers
                };
                context.Add(question);
                context.SaveChanges();
                return question.Id;
            }
        }
        public void CreateTest(TestBuilderCreate testCreate)
        {
            if (testCreate == null)
            {
                throw new Exception("CreateTest: One or more input parameters contain null");
            }
            if (string.IsNullOrEmpty(testCreate.Name))
            {
                throw new Exception("CreateTest: Name field is required");
            }
            if (string.IsNullOrEmpty(testCreate.Description))
            {
                throw new Exception("CreateTest: Description field is required");
            }
            if (testCreate.CourseId <= 0)
            {
                throw new Exception("CreateTest: CourseId field must not be empty or contain a negative value");
            }
            if (testCreate.Questions == null)
            {
                throw new Exception("CreateTest: The collection of questions cannot be empty");
            }
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var questions = new List<Question>();
                for (int i = 0; i < testCreate.Questions.Count; i++)
                {
                    var question = new Question
                    {
                        Id = testCreate.Questions[i].Id,
                        Name = testCreate.Questions[i].Name,
                        Description = testCreate.Questions[i].Description,
                        TestId = testCreate.Questions[i].TestId,
                    };
                    questions.Add(question);
                }
                var test = new Test
                {
                    Name = testCreate.Name,
                    Description = testCreate.Description,
                    CourseId = testCreate.CourseId,
                    Questions = questions
                };
                context.Add(test);
                context.SaveChanges();
            }
        }
    }
}
