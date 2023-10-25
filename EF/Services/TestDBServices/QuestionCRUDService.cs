using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.EntitiesTestDB;
using EFVaiaa.DTOTestDB;
using EFVaiaa.Interfaces;
using System.Linq;

namespace EFVaiaa.Services.TestDBServices
{
    class QuestionCRUDService
    {
        public void CreateQuestion(QuestionCreate questionCreate)
        {
            if (questionCreate == null)
            {
                throw new Exception("CreateQuestion: One or more input parameters contain null");
            }
            if (string.IsNullOrEmpty(questionCreate.Name))
            {
                throw new Exception("CreateQuestion: Name field is required");
            }
            if (string.IsNullOrEmpty(questionCreate.Description))
            {
                throw new Exception("CreateQuestion: Description field is required");
            }
            if (questionCreate.TestId <= 0)
            {
                throw new Exception("CreateQuestion: TestId field must not be empty or contain a negative value");
            }
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var question = new Question
                {
                    Name = questionCreate.Name,
                    Description = questionCreate.Description,
                    TestId = questionCreate.TestId
                };
                context.Add(question);
                context.SaveChanges();
            }
        }
        public QuestionView GetQuestion(int id)
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var question = context.Questions.FirstOrDefault(x => x.Id == id);
                if (question == null)
                {
                    throw new Exception($"GetQuestion: Question with id <{id}> not found");
                }
                return new QuestionView
                {
                    Id = question.Id,
                    Name = question.Name,
                    Description = question.Description,
                    TestId = question.TestId
                };
            }
        }
        public List<QuestionView> GetListQuestions()
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var questions = context.Questions.Select(x => new QuestionView
                {
                    Id = x.Id,
                    Name = x.Name,
                    Description = x.Description,
                    TestId = x.TestId
                }
                ).ToList();
                return questions;
            }
        }
        public void UpdateQuestion(QuestionUpdate questionUpdate)
        {
            if (questionUpdate == null)
            {
                throw new Exception("UpdateQuestion: One or more input parameters contain null");
            }
            if (string.IsNullOrEmpty(questionUpdate.Name))
            {
                throw new Exception("UpdateQuestion: Name field is required");
            }
            if (string.IsNullOrEmpty(questionUpdate.Description))
            {
                throw new Exception("UpdateQuestion: Description field is required");
            }
            if (questionUpdate.TestId <= 0)
            {
                throw new Exception("UpdateQuestion: TestId field must not be empty or contain a negative value");
            }
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var question = context.Questions.FirstOrDefault(x => x.Id == questionUpdate.Id);
                if (question == null)
                {
                    throw new Exception($"UpdateQuestion: Test with id <{questionUpdate.Id}> not found");
                }
                question.Name = questionUpdate.Name;
                question.Description = questionUpdate.Description;
                question.TestId = questionUpdate.TestId;
                context.SaveChanges();
            }
        }
        public void DeleteQuestion(int id)
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var question = context.Questions.FirstOrDefault(x => x.Id == id);
                if (question == null)
                {
                    throw new Exception($"DeleteQuestion: Question with id <{id}> not found");
                }
                context.Remove(question);
                context.SaveChanges();
            }
        }
    }
}
