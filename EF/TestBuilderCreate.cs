using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using EFVaiaa.EntitiesTestDB;

namespace EFVaiaa
{
    class TestBuilderCreate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int CourseId { get; set; }
        public List<Question> Questions { get; set; }
    }
}
