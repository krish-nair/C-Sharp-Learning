using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElseAge
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 12;
            if (age > 14)
            {
                if (age > 18)
                {
                    Console.WriteLine("Yor are Adult");
                }
                else
                {
                    Console.WriteLine("Teenager");
                }
            }
            else
            {
                if (age > 0)
                {
                    Console.WriteLine("You are child");
                }
                else
                {
                    Console.WriteLine("Something is wrong!");
                }
            }
        }
    }
}
