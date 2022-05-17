using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codebase2
{
    
    
        public delegate int operation(int a, int b);
        class Program
        {

            static int Addition(int a, int b)
            {
                return a + b;
            }

            static int subtract(int a, int b)
            {
                return a - b;
            }

            static int multiplication(int a, int b)
            {
                return a * b;
            }

            static void Main(string[] args)
            {
                operation AddObj = new operation(Program.Addition);
                operation SubObj = new operation(Program.subtract);
                operation MulObj = new operation(Program.multiplication);
                Console.WriteLine("Addition is={0}", AddObj(11, 11));
                Console.WriteLine("Subtraction is={0}", SubObj(28, 27));
                Console.WriteLine("Mutliplication is={0}", MulObj(23, 27));
                Console.ReadLine();
            }
        }
    }
