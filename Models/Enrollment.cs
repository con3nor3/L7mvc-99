///////////////////////////////////////////////////////////////////
// Date         Developer           Description
// 3/3/2021     Connor Thompson     Creation of Startup class
// 3/3/2021     Connor Thompson     Created methods for Grade, CourseID, StudentDB, and student
// 3/3/2021     Connor Thompson     finished class
namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-03-connorT-dykstra1] -- Enum for letter grades and instantiation of courseID, Grade and student
    public enum Grade
    {
        A, B, C, D, F
    }
    public class Enrollment
    {
        public int EnrollmentID { get; set; }

        public int CourseID { get; set; }

        public int StudentID { get; set; }

        public Grade? Grade { get; set; }
        public Student Student { get; set; }
    }
}