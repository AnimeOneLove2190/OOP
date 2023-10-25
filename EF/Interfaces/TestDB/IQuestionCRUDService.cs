using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.DTOTestDB;
using EFVaiaa.Services.TestDBServices;

namespace EFVaiaa.Interfaces.TestDB
{
    interface IQuestionCRUDService
    {
        public void CreateQuestion(QuestionCreate questionCreate);
        public QuestionView GetQuestion(int id);
        public List<QuestionView> GetListQuestions();
        public void UpdateQuestion(QuestionUpdate questionUpdate);
        public void DeleteQuestion(int id);
    }
}
