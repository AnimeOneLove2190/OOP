using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.EntitiesTestDB
{
    public class SomeUser
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string FullName { get; set; }
        public ICollection<PossibleAnswer> PossibleAnswers { get; set; }
    }
}
