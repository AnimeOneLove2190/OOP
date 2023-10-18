using System;
using System.Collections.Generic;
using System.Text;

namespace EFVaiaa.EntitiesTestDB
{
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public ICollection<Question> Questions { get; set; }
    }
}
