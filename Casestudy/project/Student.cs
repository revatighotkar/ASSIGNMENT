using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
    public class Student
    {
        public Student()
        {

        }
        public Student(int id, string name, string dob)
        {
            Id = id;
            Name = name;
            Dob = dob;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dob { get; set; }
    }

}
