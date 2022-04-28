using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmenT_3
{
    internal class Program
    {
        static void Main(string[] args)
        
			internal class Student
		{
			int rollno;
			String name;
			String branch;
			String sem;
			String Section;

			static public void displayResult()
			{
				int[] marks = new int[5];
				marks[0] = 10;
				marks[1] = 20;
				marks[2] = 30;
				marks[3] = 40;
				marks[4] = 50;

				for (int i = 0; i < marks.Length; i++)
				{
					Console.WriteLine("the marks of " + i + " subs are: " + marks[i]);
				}

				double average = marks.Average();

				for (int i = 0; i < marks.Length; i++)
				{
					if (marks[i] >= 35)
					{
						Console.WriteLine("FAILED");
					}
					else if (marks[i] > 35 && average < 50)
					{
						Console.WriteLine("FAILED");
					}
					else if (average > 50)
					{
						Console.WriteLine("PASSED");
					}
					else
					{
						Console.WriteLine("INVALID");
					}
				}
			}
			public Student(int rollno, String name, String branch, String sem, String Section)
			{
				this.rollno = rollno;
				this.name = name;

				this.branch = branch;
				this.sem = sem;
				this.Section = Section;
				Console.WriteLine($"\nRollno is: {rollno}, Name is {name},Student class is {Section}, Sem is {sem},Branch is : {branch}");
			}
			static public void displayData()

			{
				Console.WriteLine("\nthe marks: ");
			}


			//CAR details****************

			internal class Car
			{
				int car_no;
				string car_name;
				string car_type;
				readonly double cost = 700000;
				public Car(int car_no, string car_name, string car_type, double cost)
				{
					this.car_no = car_no;
					this.car_name = car_name;
					this.car_type = car_type;
					this.cost = cost;
					Console.WriteLine($"\nthe car_no is {car_no},car_name is {car_name},car_type is {car_type},cost is {cost} ");
				}
				public void showDetails()
				{
					Console.WriteLine("\nbefore changing");
					Console.WriteLine($"the car_no is {car_no},car_name is {car_name},car_type is {car_type},cost is {cost} ");
				}
				public Car(double car_cost)
				{
					Console.WriteLine("\nafter changing");
					car_cost = cost;
					Console.WriteLine($"the car_no is {car_no},car_name is {car_name},car_type is {car_type},cost is {cost} ");

				}
			}

			//BANK LOAN *************************
			internal class bank
			{
				double interestRate;
				public void loanCalculator(double loanamt)
				{
					Console.WriteLine("\nPlease enter rate of interest");
					interestRate = Convert.ToDouble(Console.ReadLine());
					double interest = (loanamt * interestRate) / 100;
					Console.WriteLine("\nRate of interest for " + interestRate + "(in percentage ) % is : " + interest);
				}

			}



			internal class Program
			{
				static void Main(string[] args)
				{
					//STUDENT*******************
					Student.displayResult();
					Student student = new Student(06, "Revati", "EE-c", "4-2", "Electrical");
					Student.displayData();

					//CAR*****************************
					Car car = new Car(123, "ferrai", "sports", 5000000);
					car.showDetails();
					Car car2 = new Car(20000000);

					//BANK**********************
					bank bank = new bank();
					Console.WriteLine("\nenter the loan amount: ");
					bank.loanCalculator(Convert.ToInt32(Console.ReadLine()));

					Console.ReadLine();


				}
			}
		}

	}

}
    