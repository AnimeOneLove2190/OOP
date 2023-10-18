using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.EntitiesTestDB
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Test> Tests { get; set; }
    }
}
