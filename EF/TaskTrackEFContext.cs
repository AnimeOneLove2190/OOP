using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using EFVaiaa.EntitiesTaskTrack;

namespace EFVaiaa
{
    public class TaskTrackEFContext : DbContext
    {
        public DbSet<SomeUserTasks> SomeUsers { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Task> Tasks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=TaskTrackEF;Initial Catalog=TaskTrackEF;Integrated Security=True;");
        }
    }
}
