using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSIGNMENT_6
{
    public interface IStudent
    {
        int StudentId
        {
            get;
            set;
        }
        string Name
        {
            get;
            set;
        }
        void showDetails();
    }
    public class DayScholar : IStudent
    {
        private int _StudentId;
        public int StudentId
        {
            get { return _StudentId; }
            set { _StudentId = value; }
        }
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }

        }
        public void showDetails()
        {
            Console.WriteLine("Student Name is " + _Name + " and his Student id = " + _StudentId);
        }

    }
    public class Resident : IStudent
    {
        private int _StudentId;
        public int StudentId
        {
            get { return _StudentId; }
            set { _StudentId = value; }
        }
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }

        }
        public void showDetails()
        {
            Console.WriteLine("Student Name is " + _Name + " and his Student id = " + _StudentId);
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            IStudent student = new DayScholar();
            Console.WriteLine("Enter Student Id");
            student.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Student Name");
            student.Name = Console.ReadLine();
            student.showDetails();
            IStudent student2 = new Resident();
            Console.WriteLine("Enter 2nd Student Id");
            student2.StudentId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd Student Name");
            student2.Name = Console.ReadLine();
            student2.showDetails();
            Console.ReadLine();
        }
    }
}
