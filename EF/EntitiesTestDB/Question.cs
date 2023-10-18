using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.EntitiesTestDB
{
    public class Question
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TestId { get; set; }
        public Test Test { get; set; }
        public ICollection<PossibleAnswer> PossibleAnswers { get; set; }
    }
}
