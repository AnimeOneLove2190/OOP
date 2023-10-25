using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOTestDB;
using EFVaiaa.Services.TestDBServices;

namespace EFVaiaa.Interfaces.TestDB
{
    interface IPossibleAnswerCRUDService
    {
        public void CreatePossibleAnswer(PossibleAnswerCreate possibleAnswerCreate);
        public PossibleAnswerView GetPossibleAnswer(int id);
        public List<PossibleAnswerView> GetListPossibleAnswers();
        public void UpdatePossibleAnswer(PossibleAnswerUpdate possibleAnswerUpdate);
        public void DeletePossibleAnswer(int id);
    }
}
