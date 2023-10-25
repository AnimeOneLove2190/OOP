using System;
using System.Collections.Generic;
using System.Text;
using EFVaiaa.EntitiesTestDB;

namespace EFVaiaa.DTOTestDB
{
    class SomeUserView
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string FullName { get; set; }
        public ICollection<PossibleAnswer> PossibleAnswers { get; set; }
    }
}
