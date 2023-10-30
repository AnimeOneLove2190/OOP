using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.DTOTestDB
{
    class SomeUserUpdate
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string FullName { get; set; }
    }
}
