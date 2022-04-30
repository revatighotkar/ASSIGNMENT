using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
internal class Program
	{
		class Bank
		{
			readonly int money = 25000;
			readonly String acc_name = "REVATI";
		     String acc_num;
			readonly static String bank_name = "HDFC Bank";
			static public int updatedBalance;

            public string Acc_num { get => acc_num; set => acc_num = value; }

            public void DepositMoney()
			{

				Console.WriteLine("\nEnter the amount you want to deposit:");
				int depMoney = int.Parse(Console.ReadLine());
				updatedBalance = money + depMoney;
				if (depMoney == 0)
				{
					Console.WriteLine("minimum deposit should be 500 ");
				}
				else
				{
					Console.WriteLine("updated balance of " + acc_name + " after deposit is " + updatedBalance);
				}

			}
			public void WithdrawMoney()
			{
				try
				{
					Console.WriteLine("Welcome! " + acc_name + " your account balance: " + updatedBalance);
					Console.WriteLine("\nEnter the amount you want to withdraw:");
					int withdraw = int.Parse(Console.ReadLine());
					updatedBalance  = updatedBalance - withdraw;
					if (withdraw > updatedBalance)
					{
						Console.WriteLine("insuffiecient balance");
					}
					else
					{
						Console.WriteLine("updated balance of " + acc_name + " after withdrawal is " + updatedBalance);
					}

				}
				catch (Exception )
				{
					Console.WriteLine("enter balance in number not in words inputmissmatch exception ");
				}
			}
			public void Balance()
			{
				Console.WriteLine("welcome to the " + bank_name + "bank ");
				Console.WriteLine("Enter account number: ");
				acc_num = Console.ReadLine();
				Console.WriteLine("Welcome! " + acc_name + " your account balance: " + money);

			}
		}
		static void Main()
        {
			Bank bank = new Bank();
			bank.Balance();
			bank.DepositMoney();
			bank.WithdrawMoney();
			Console.ReadLine();
		}
	}
}