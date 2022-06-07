using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Enroll
    {
        
        public Enroll(Student student, Course course, DateTime enrollmentDate)
        {

            Student = student;
            Course = course;
            EnrollmentDate = enrollmentDate;
        }
        public  Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }

}

    }

