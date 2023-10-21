using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.EntitiesTaskTrack
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SomeUserTasks> SomeUsers { get; set; }
    }
}
