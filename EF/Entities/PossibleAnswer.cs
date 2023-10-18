using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.Entities
{
    public class PossibleAnswer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRight { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
        public ICollection<SomeUser> SomeUsers { get; set; }
    }
}
