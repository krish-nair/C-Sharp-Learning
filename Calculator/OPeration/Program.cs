using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPeration
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string operand;
            double answer = 0;            


            Console.WriteLine("Please enter a number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the operand: (+, -, *, % or /)");
            operand = Console.ReadLine();

            switch (operand)
            {
                case "+":
                    answer = num1 + num2;
                    break;
                case "-":
                    answer = num1 - num2;
                    break;
                case "*":
                    answer = num1 * num2;
                    break;
                case "/":
                    answer = num1 / num2;
                    break;
                case "%":
                    answer = num1 % num2;
                    break;
            }
            Console.WriteLine("\nResult of " + num1 + " " + operand + " " + num2 + " " + "=" + " " + answer);

            Console.ReadKey();
        }
    }
}
