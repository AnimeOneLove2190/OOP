using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.DTOTestDB
{
    class PossibleAnswerUpdate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRight { get; set; }
        public int QuestionId { get; set; }
    }
}
