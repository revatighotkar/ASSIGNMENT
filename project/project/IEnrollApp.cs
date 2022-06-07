using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
   public interface IEnrollApp
    {
         int register(Student student);
         int UpdateStudent(int id, string name, string dob);
         int deleteStudent(int id);
         Student getStudent(int id);
         List<Student> getStudents();
         int addCourse(Course course);
        List<Course> getCourses();
        int deleteCourse(int id);
    }
}
