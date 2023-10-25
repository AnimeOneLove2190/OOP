using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.EntitiesTestDB;

namespace EFVaiaa.DTOTestDB
{
    class RecordAnswerView
    {
        public int PossibleAnswerId { get; set; }
        public string PossibleAnswerName { get; set; }
        public int SomeUserId { get; set; }
        public string SomeUserName { get; set; }
    }
}
