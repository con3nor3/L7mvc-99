///////////////////////////////////////////////////////////////////
// Date         Developer           Description
// 3/3/2021     Connor Thompson     Creation of SchoolContext class
// 3/3/2021     Connor Thompson     added methods to build the students
// 3/3/2021     Connor Thompson     finished class

using ContosoUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace ContosoUniversity.Data
{
    public class SchoolContext : DbContext
    {
        //tinfo200:[2021-03-03-con3nor3-dykstra1] -- Added get and set methods for building the students and their information
        public SchoolContext(DbContextOptions<SchoolContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }

        //tinfo200:[2021-03-03-con3nor3-dykstra1] -- used to build lists of students information
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");
            modelBuilder.Entity<Student>().ToTable("Student");
        }
    }
}
