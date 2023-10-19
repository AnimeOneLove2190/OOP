using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.EntitiesTaskTrack
{
    public class SomeUserTasks
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
        public ICollection<Role> Roles { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
