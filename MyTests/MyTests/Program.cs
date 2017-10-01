using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTests
{
    class Program
    {
        static void Main(string[] args)
        {/*
            double d = 4.0;
            double e = 3.0;
            Console.WriteLine("{0:N1}", d + e);
        


            // Calculating total meal cost including tip and tax and getting a rounded value.
            

            double mealCost;
            int tipPercent;
            int taxPercent;

            Console.WriteLine("Please enter the total meal cost before tax and tip: ");
            mealCost = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the tip percent: ");
            tipPercent = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the tax percent: ");
            taxPercent = Convert.ToInt32(Console.ReadLine());
            

            double tip = mealCost * tipPercent / 100;
            double tax = mealCost * taxPercent / 100;
            double totalCost = mealCost + tip + tax;

            totalCost = Math.Round(totalCost);

            Console.WriteLine("The total meal cost is {0} dollars.", totalCost);
            --------------------------------------------------------------------

            int N = Convert.ToInt32(Console.ReadLine());
            if (N % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else if(N < 6 && N % 2 == 0)
            {
                Console.WriteLine("Not Weird");
            }
            else if(N < 21 && N % 2 == 0)
            {
                Console.WriteLine("Weird");
            }
            else if(N > 20 && N % 2 == 0)
            {
                Console.WriteLine("Not Weird");

            }
            --------------------------------------------*/
           // SayHello();
            var intVal = 10;
            Console.WriteLine("Datatype : {0}", intVal.GetType());
            Console.ReadLine();

        }
        private static void SayHello()
        {
            string name = "";
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            Console.WriteLine("Hello {0}", name);
        }
    }
}
