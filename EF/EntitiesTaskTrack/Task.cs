using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.EntitiesTaskTrack
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsCompleted { get; set; }
        public ICollection<SomeUserTasks> SomeUsers { get; set; }
    }
}
