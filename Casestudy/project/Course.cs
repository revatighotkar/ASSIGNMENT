using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project
{
   public class Course
    {
        public Course()
        { }
            public Course(int id, string name, int duration,int fees)
        {
            Name = name;
            Id = id;
            Duration = duration;
            Fees = fees;
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public int Duration{ get; set; }
        public int Fees { get; set; }
    }


}

