using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.EntitiesTestDB;
using EFVaiaa.DTOTestDB;
using EFVaiaa.Interfaces;
using System.Linq;

namespace EFVaiaa.Services.TestDBServices
{
    class PossibleAnswerCRUDService
    {
        public void CreatePossibleAnswer(PossibleAnswerCreate possibleAnswerCreate)
        {
            if (possibleAnswerCreate == null)
            {
                throw new Exception("CreatePossibleAnswer: One or more input parameters contain null");
            }
            if (string.IsNullOrEmpty(possibleAnswerCreate.Name))
            {
                throw new Exception("CreatePossibleAnswer: Name field is required");
            }
            if (possibleAnswerCreate.QuestionId <= 0)
            {
                throw new Exception("CreatePossibleAnswer: QuestionId field must not be empty or contain a negative value");
            }
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var possibleAnswer = new PossibleAnswer
                {
                    Name = possibleAnswerCreate.Name,
                    IsRight = possibleAnswerCreate.IsRight,
                    QuestionId = possibleAnswerCreate.QuestionId
                };
                context.Add(possibleAnswer);
                context.SaveChanges();
            }
        }
        public PossibleAnswerView GetPossibleAnswer(int id)
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var possibleAnswer = context.PossibleAnswers.FirstOrDefault(x => x.Id == id);
                if (possibleAnswer == null)
                {
                    throw new Exception($"GetPossibleAnswer: Answer with id <{id}> not found");
                }
                return new PossibleAnswerView
                {
                    Id = possibleAnswer.Id,
                    Name = possibleAnswer.Name,
                    IsRight = possibleAnswer.IsRight,
                    QuestionId = possibleAnswer.QuestionId
                };
            }
        }
        public List<PossibleAnswerView> GetListPossibleAnswers()
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var possibleAnswers = context.PossibleAnswers.Select(x => new PossibleAnswerView
                {
                    Id = x.Id,
                    Name = x.Name,
                    IsRight = x.IsRight,
                    QuestionId = x.QuestionId
                }
                ).ToList();
                return possibleAnswers;
            }
        }
        public void UpdatePossibleAnswer(PossibleAnswerUpdate possibleAnswerUpdate)
        {
            if (possibleAnswerUpdate == null)
            {
                throw new Exception("UpdatePossibleAnswer: One or more input parameters contain null");
            }
            if (string.IsNullOrEmpty(possibleAnswerUpdate.Name))
            {
                throw new Exception("UpdatePossibleAnswer: Name field is required");
            }
            if (possibleAnswerUpdate.QuestionId <= 0)
            {
                throw new Exception("UpdatePossibleAnswer: QuestionId field must not be empty or contain a negative value");
            }
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var possibleAnswer = context.PossibleAnswers.FirstOrDefault(x => x.Id == possibleAnswerUpdate.Id);
                if (possibleAnswer == null)
                {
                    throw new Exception($"UpdatePossibleAnswer: PossibleAnswer with id <{possibleAnswerUpdate.Id}> not found");
                }
                possibleAnswer.Name = possibleAnswerUpdate.Name;
                possibleAnswer.IsRight = possibleAnswerUpdate.IsRight;
                possibleAnswer.QuestionId = possibleAnswerUpdate.QuestionId;
                context.SaveChanges();
            }
        }
        public void DeletePossibleAnswer(int id)
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var possibleAnswer = context.PossibleAnswers.FirstOrDefault(x => x.Id == id);
                if (possibleAnswer == null)
                {
                    throw new Exception($"DeletePossibleAnswer: PossibleAnswer with id <{id}> not found");
                }
                context.Remove(possibleAnswer);
                context.SaveChanges();
            }
        }
    }
}
