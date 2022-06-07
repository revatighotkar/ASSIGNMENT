using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    class Program
    {   
        static void Main(string[] args)
        {
            EnrollApp enrollApp = new EnrollApp();

            Console.WriteLine("------------------------------------------------------------------------------------------");
            do
            {
                Console.WriteLine("1.Student Menu\n2.Admin Menu\n3.Exit");
                Console.WriteLine("enter option");
                int menu_op = Convert.ToInt32(Console.ReadLine());
                switch(menu_op) {
                    case 1:
                        Console.WriteLine("1.Insert student\n2.Delete Student\n3.update Student\n4.Get Details\n5.StudentsDetails\n6.Exit");
                        Console.WriteLine("enter option");
                        int op = Convert.ToInt32(Console.ReadLine());
                        if (op == 1)
                        {
                            Student student = new Student();
                            Console.WriteLine("Enter Id");
                            student.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            student.Name = Console.ReadLine();
                            Console.WriteLine("Enter Dob");
                            student.Dob = Console.ReadLine();
                            int result = enrollApp.register(student);
                            if (result == 1)
                            {
                                Console.WriteLine("Inserted Successfully");
                            }
                            else {
                                Console.WriteLine(" Fail to Insert");
                            }
                        }
                        if (op == 2)
                        {
                            Console.WriteLine("Enter id to delete");
                            int id = Convert.ToInt32(Console.ReadLine());
                            int res = enrollApp.deleteStudent(id);
                            if (res == 1)
                            {
                                Console.WriteLine("Deleted Successfully");
                            }
                            else
                            {
                                Console.WriteLine(" Fail to Delete");
                            }
                        }
                        if (op == 3)
                        {
                            Console.WriteLine("Enter Id to update");
                            int Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            string Name = Console.ReadLine();
                            Console.WriteLine("Enter Dob");
                            string Dob = Console.ReadLine();
                            int result = enrollApp.UpdateStudent(Id,Name ,Dob);
                            if (result == 1)
                            {
                                Console.WriteLine("update Successfully");
                            }
                            else
                            {
                                Console.WriteLine(" Fail to update");
                            }

                        }
                        if (op == 4)
                        {
                            Console.WriteLine("Enter id to get Details");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Student s = enrollApp.getStudent(id);
                            Console.WriteLine("------------------");
                            Console.WriteLine("STUDENTID NAME DOB");
                            Console.WriteLine(" " + s.Id + " " + s.Name + " " + s.Dob);
                            Console.WriteLine("------------------");

                        }
                        if (op == 5)
                        {
                            List<Student> l1 = new List<Student>();
                            l1 = enrollApp.getStudents();
                            Console.WriteLine("------------------");
                            Console.WriteLine("STUDENTID NAME DOB");
                            foreach (var x in l1)
                            {
                                Console.WriteLine(" " + x.Id + " " + x.Name + " " + x.Dob);
                            }
                            Console.WriteLine("------------------");
                        }
                        if (op == 6)
                        {
                            Environment.Exit(0);
                        }
                    break;
                    case 2:
                        Console.WriteLine("1.Insert Course\n2.Delete Course\n3.Get Courses\n4.Exit");
                        Console.WriteLine("enter option");
                        int op1 =  Convert.ToInt32(Console.ReadLine());
                        if(op1 == 1){
                            Course course = new Course();
                            Console.WriteLine("Enter Id");
                            course.Id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Name");
                            course.Name = Console.ReadLine();
                            Console.WriteLine("Enter Duration");
                            course.Duration = Convert.ToInt32( Console.ReadLine());
                            Console.WriteLine("Enter Fees");
                            course.Fees = Convert.ToInt32(Console.ReadLine());
                            int result = enrollApp.addCourse(course);
                            if (result == 1)
                            {
                                Console.WriteLine("Inserted Successfully");
                            } else {
                                Console.WriteLine(" Fail to Insert");
                            }
                        }
                        if(op1 == 2){
                            Console.WriteLine("Enter id to delete");
                            int id = Convert.ToInt32(Console.ReadLine());
                            int res = enrollApp.deleteCourse(id);
                            if (res == 1)
                            {
                                Console.WriteLine("Deleted Successfully");
                            } else
                            {
                                Console.WriteLine(" Fail to Delete");
                            }
                        }
                        if(op1 == 3){
                            List<Course> l1 = new List<Course>();
                            l1 = enrollApp.getCourses();
                            Console.WriteLine("------------------");
                            Console.WriteLine("CourseId Course_Name Course_Duration Course_Fees");
                            foreach (var x in l1)
                            {
                                Console.WriteLine(" " + x.Id + " " + x.Name + " " + x.Duration + " " + x.Fees);
                            }
                            Console.WriteLine("------------------");
                        }
                        if(op1 == 4){
                            Environment.Exit(0);
                        }
                    break;
                    case 3:
                        Environment.Exit(0);
                    break;
                    default:
                        Environment.Exit(0);
                    break;
                }

            } while (true);
        }
    }
}
