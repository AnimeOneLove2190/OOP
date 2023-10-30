using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.EntitiesTestDB;
using EFVaiaa.Interfaces;

namespace EFVaiaa.DTOTestDB1
{
    class QuestBuilderCreate
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int TestId { get; set; }
        public List<PossibleAnswerStub> PossibleAnswers { get; set; }
    }
}
