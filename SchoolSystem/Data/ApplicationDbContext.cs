using SchoolSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<ClassType> ClassTypes { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentNote> StudentNotes { get; set; }
        public DbSet<TaskInSchool> TaskInSchools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Worker> Workers { get; set; }
        public DbSet<StudentAbsent> StudentAbsents { get; set; }
        public DbSet<Holiday> Holidays { get; set; }
    }
}
