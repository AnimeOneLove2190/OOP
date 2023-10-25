using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOTestDB;
using EFVaiaa.Services.TestDBServices;

namespace EFVaiaa.Interfaces.TestDB
{
    interface IRecordAnswerCRUDService
    {
        public void CreateRecordAnswer(RecordAnswerCreate recordAnswerCreate); //У этого метода старая архитектура
        public RecordAnswerView GetRecordAnswer(int possibleAnswerId, int someUserId);
        public List<RecordAnswerView> GetRecordAnswersList();
        public void DeleteRecordAnswer(int possibleAnswerId, int someUserId);
    }
}
