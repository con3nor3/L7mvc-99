///////////////////////////////////////////////////////////////////
// Date         Developer           Description
// 3/3/2021     Connor Thompson     Creation of Startup class
// 3/3/2021     Connor Thompson     Created methods for the student information
// 3/3/2021     Connor Thompson     finished class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-03-connorT-dykstra1] -- Instantiates the students information
    public class Student
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstMidName { get; set; }

        public DateTime EnrollmentDate { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }


    }
}
