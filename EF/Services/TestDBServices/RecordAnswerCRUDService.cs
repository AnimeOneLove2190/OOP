using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.EntitiesTestDB;
using EFVaiaa.DTOTestDB;
using EFVaiaa.Interfaces.TestDB;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFVaiaa.Services.TestDBServices
{
    class RecordAnswerCRUDService : IRecordAnswerCRUDService
    {
        private readonly SomeUserCRUDService someUserCRUDService;
        private readonly PossibleAnswerCRUDService possibleAnswerCRUDService;
        public RecordAnswerCRUDService()
        {
            this.someUserCRUDService = new SomeUserCRUDService();
            this.possibleAnswerCRUDService = new PossibleAnswerCRUDService();
        }
        public void CreateRecordAnswer(RecordAnswerCreate recordAnswerCreate) //У этого метода старая архитектура
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var someUser = context.SomeUsers.FirstOrDefault(x => x.Id == recordAnswerCreate.SomeUserId);
                if (someUser == null)
                {
                    throw new Exception($"CreateRecordAnswer: SomeUser with id <{recordAnswerCreate.SomeUserId}> not found");
                }
                var possibleAnswer = context.PossibleAnswers.FirstOrDefault(x => x.Id == recordAnswerCreate.PossibleAnswerId);
                if (possibleAnswer == null)
                {
                    throw new Exception($"CreateRecordAnswer: PossibleAnswer with id <{recordAnswerCreate.PossibleAnswerId}> not found");
                }
                someUser.PossibleAnswers = new List<PossibleAnswer>
                {
                    possibleAnswer
                };
                possibleAnswer.SomeUsers = new List<SomeUser>
                {
                    someUser
                };
                context.SaveChanges();
            }
        }
        public RecordAnswerView GetRecordAnswer(int possibleAnswerId, int someUserId)
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var possibleAnswer = context.PossibleAnswers.Include(x => x.SomeUsers).FirstOrDefault(x => x.Id == possibleAnswerId && x.SomeUsers.Any(s => s.Id == someUserId));
                if (possibleAnswer == null)
                {
                    throw new Exception($"GetRecordAnswer: PossibleAnswer with id <{possibleAnswerId}> not found");
                }
                var someUsersIds = possibleAnswer.SomeUsers.Select(x => x.Id).ToList();
                if (!(someUsersIds.Contains(someUserId)))
                {
                    throw new Exception($"Composite key <PossibleAnswerId {possibleAnswerId} - UserId {someUserId}> not found");
                }
                var someUser = possibleAnswer.SomeUsers.FirstOrDefault(x => x.Id == someUserId);
                return new RecordAnswerView
                {
                    PossibleAnswerId = possibleAnswer.Id,
                    PossibleAnswerName = possibleAnswer.Name,
                    SomeUserId = someUser.Id,
                    SomeUserName = someUser.FullName,
                };
            }
        }
        public List<RecordAnswerView> GetRecordAnswersList()
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var recordAnswers = new List<RecordAnswerView>();
                var possibleAnswers = context.PossibleAnswers.Include(x => x.SomeUsers).ToList();
                if (possibleAnswers == null)
                {
                    throw new Exception($"GetRecordAnswer: PossibleAnswers not found");
                }
                for (int i = 0; i < possibleAnswers.Count; i++)
                {
                    var someUsers = possibleAnswers[i].SomeUsers.ToList();
                    if (someUsers == null)
                    {
                        Console.WriteLine($"Possible Answer with Id <{possibleAnswers[i].Id}> does not contain SomeUsers");
                        continue;
                    }
                    for (int j = 0; j < someUsers.Count; j++)
                    {
                        var recordAnswer = new RecordAnswerView
                        {
                            PossibleAnswerId = possibleAnswers[i].Id,
                            PossibleAnswerName = possibleAnswers[i].Name,
                            SomeUserId = someUsers[j].Id,
                            SomeUserName = someUsers[j].FullName,
                        };
                        recordAnswers.Add(recordAnswer);
                    }
                }
                return recordAnswers;
            }
        }
        public void DeleteRecordAnswer(int possibleAnswerId, int someUserId)
        {
            using (TestDBEFContext context = new TestDBEFContext())
            {
                var possibleAnswer = context.PossibleAnswers.Include(x => x.SomeUsers).FirstOrDefault(x => x.Id == possibleAnswerId && x.SomeUsers.Any(s => s.Id == someUserId));
                if (possibleAnswer == null)
                {
                    throw new Exception($"GetRecordAnswer: PossibleAnswer with id <{possibleAnswerId}> not found");
                }
                var someUsersIds = possibleAnswer.SomeUsers.Select(x => x.Id).ToList();
                if (!(someUsersIds.Contains(someUserId)))
                {
                    throw new Exception($"Composite key <PossibleAnswerId {possibleAnswerId} - UserId {someUserId}> not found");
                }
                var someUser = possibleAnswer.SomeUsers.FirstOrDefault(x => x.Id == someUserId);
                possibleAnswer.SomeUsers.Remove(someUser);
                context.SaveChanges();
            }
        }
    }
}
