using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.EntitiesTestDB;
using System.Linq;
using EFVaiaa.Interfaces;

namespace EFVaiaa.Services
{
    class TestBuilder 
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
                var question = new Question
                {
                    Name = questBuilder.Name,
                    Description = questBuilder.Description,
                    TestId = questBuilder.TestId,
                    PossibleAnswers = questBuilder.PossibleAnswers
                };
                context.Add(question);
                context.SaveChanges();
                var questions = context.Questions.ToList();
                var justCreatedQuestion = new Question();
                for (int i = questions.Count - 1; i < questions.Count; i++)
                {
                    justCreatedQuestion = questions[i];
                }
                return justCreatedQuestion.Id;
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
                var test = new Test
                {
                    Name = testCreate.Name,
                    Description = testCreate.Description,
                    CourseId = testCreate.CourseId,
                    Questions = testCreate.Questions
                };
                context.Add(test);
                context.SaveChanges();
            }
        }
    }
}
