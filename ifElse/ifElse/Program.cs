using System;


namespace ifElse
{
    class Program
    {
        static void Print(int x)
        {
            int result = x / 2;
            Console.WriteLine("\n So x / 2 = {0}", result);

        }
        static void sayHi()
        {
            Console.WriteLine("Hllo World!");
        }
        static void MyAge(string theName, int year)
        {

            int age = 2017 - year;
            Console.WriteLine("Hi {0} you are {1} years old...", theName, age);
        }
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
                       
            Console.WriteLine("What is your birth year?");
            int yob = Convert.ToInt32(Console.ReadLine());


            MyAge(name, yob);

            Console.WriteLine("\n\n");
            
            sayHi();
            sayHi();
            sayHi();

            Print(40);

            Console.WriteLine("\n");

            int age = 18;
            if (age > 17)
            {
                Console.WriteLine("You are welocome!");
            }
            else
            {
                Console.WriteLine("Sorry you are not authorized");
            }

            Console.WriteLine("\n");

            int mark = 80;
            if (mark >= 100)
            {
                Console.WriteLine("you passed!");

                if (mark == 100)
                {
                    Console.WriteLine("perfect!");
                }
            }
            else
            {
                Console.WriteLine("You are failed");
            } 

        }
    }
}
