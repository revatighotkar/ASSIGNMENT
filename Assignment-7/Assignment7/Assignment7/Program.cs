using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{

    class Employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmpTitle { get; set; }
        public string DOB { get; set; }
        public DateTime DOJ { get; set; }
        public string City { get; set; }


        public List<Employee> GetEmployees()
        {
            List<Employee> Emplist = new List<Employee>();
            Employee e1 = new Employee { EmpId = 1001, FirstName = "Malcolm", LastName = "Daruwalla", EmpTitle = "Manager", DOB = "16-11-1984", DOJ = DateTime.Parse("8/6/2011"), City = "Mumbai" };
            Employee e2 = new Employee { EmpId = 1002, FirstName = "Asdin", LastName = "Dhalla", EmpTitle = "AsstManager", DOB = "20/08/1984", DOJ = DateTime.Parse("7/7/2012"), City = "Mumbai" };
            Employee e3 = new Employee { EmpId = 1003, FirstName = "Madhavi", LastName = "Oza", EmpTitle = "Consultant", DOB = "14/11/1987", DOJ = DateTime.Parse("12/4/2015"), City = "Pune" };
            Employee e4 = new Employee { EmpId = 1004, FirstName = "Saba", LastName = "Shaikh", EmpTitle = "SE", DOB = "3/6/1990", DOJ = DateTime.Parse("2/2/2016"), City = "Pune" };
            Employee e5 = new Employee { EmpId = 1005, FirstName = "Nazia", LastName = "Shaikh", EmpTitle = "SE", DOB = "8/3/1991", DOJ = DateTime.Parse("2/2/2016"), City = "Mumbai" };
            Employee e6 = new Employee { EmpId = 1006, FirstName = "Amit", LastName = "Pathak", EmpTitle = "Consultant", DOB = "7/11/1989", DOJ = DateTime.Parse("8/8/2014"), City = "Chennai" };
            Employee e7 = new Employee { EmpId = 1007, FirstName = "Vijay", LastName = "Natrajan", EmpTitle = "Consultant", DOB = "2/12/1989", DOJ = DateTime.Parse("1/6/2015"), City = "Mumbai" };
            Employee e8 = new Employee { EmpId = 1008, FirstName = "Rahul", LastName = "Dubey", EmpTitle = "Associate", DOB = "11/11/1993", DOJ = DateTime.Parse("6/11/2014"), City = "Chennai" };
            Employee e9 = new Employee { EmpId = 1009, FirstName = "Suresh", LastName = "Mistry", EmpTitle = "Associate", DOB = "12/8/1992", DOJ = DateTime.Parse("3/12/2014"), City = "Chennai" };
            Employee e10 = new Employee { EmpId = 1010, FirstName = "Sumit", LastName = "Shah", EmpTitle = "Manager", DOB = "12/4/1991", DOJ = DateTime.Parse("2/1/2016"), City = "Pune" };
            Emplist.Add(e1);
            Emplist.Add(e2);
            Emplist.Add(e3);
            Emplist.Add(e4);
            Emplist.Add(e5);
            Emplist.Add(e6);
            Emplist.Add(e7);
            Emplist.Add(e8);
            Emplist.Add(e9);
            Emplist.Add(e10);
            return Emplist;
        }

        public override string ToString()
        {

            return string.Format("Empid :" + " " + EmpId + "  " + "FirstName :" + " " + FirstName + "  " + "LastName :" + " " + LastName + "  " + "EmpTitle :" + "  " + EmpTitle + " " + "DOB :" + "  " + DOB + "  " + "DOJ :" +
                "  " + DOJ + "  " + " City :" + "  " + City);
        }


    }
    internal class Programs
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            var EmpCount = (from e in emp.GetEmployees()
                            select e).Count();
            Console.WriteLine("Total no.of employees is :" + EmpCount);
            Console.WriteLine("------------------------------------------");

            var ecity = (from e in emp.GetEmployees()
                         where e.City == "Chennai"
                         select e).Count();

            Console.WriteLine("Total no.of Employees in chennai is :" + ecity);
            Console.WriteLine("------------------------------------------");

            var emcity = (from e in emp.GetEmployees()
                          where e.City == "Mumbai"
                          select e).Count();

            Console.WriteLine("Total no.of Employees in mumbai is :" + emcity);
            Console.WriteLine("------------------------------------------");

            var empcity = (from e in emp.GetEmployees()
                           where e.City == "Pune"
                           select e).Count();

            Console.WriteLine("Total no.of Employees in pune is :" + empcity);
            Console.WriteLine("------------------------------------------");

            var eboth = (from e in emp.GetEmployees()
                         where ((e.EmpTitle == "Consultant") || (e.EmpTitle == "Associate"))
                         select e).ToList();

            foreach (var etitle in eboth)
            {
                Console.WriteLine(etitle);
            }

            Console.WriteLine("-------------------------------------");

            var empdoj = (from edoj in emp.GetEmployees()
                          where edoj.DOJ > Convert.ToDateTime("1/1/2015")
                          select edoj).Count();
            Console.WriteLine("Total no.of employees 1/1/2015 after joining : " + empdoj);
            Console.WriteLine("-------------------------------------------------------");

            var emphighest = emp.GetEmployees().Max(e => e.EmpId);
            Console.WriteLine("Highest employee id is : " + emphighest);

            Console.WriteLine("----------------------------------------------------");

            var empt = (from e in emp.GetEmployees()
                        where e.EmpTitle != "Associate"
                        select e).Count();
            Console.WriteLine("total no.of non-associates Employes is : " + empt);
            Console.WriteLine("-----------------------------------------------");

            //var empyoungest = (emp.GetEmployees().Max(e => e.DOB)).Count();
            //Console.WriteLine("youngest employee is : " + empyoungest);

            //var empdob = (from e in emp.GetEmployees()
            //              where e.DOB > Convert.ToDateTime("1/1/1990")
            //              select e).ToList();

            //foreach(var edob in empdob)
            //{
            //    Console.WriteLine(edob);
            //}

            Console.ReadKey();
        }
    }
}

