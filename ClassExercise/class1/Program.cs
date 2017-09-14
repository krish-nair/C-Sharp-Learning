using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class1
{
    /*class Person
    {
        string name;
        int age;
        public void SayHi()
        {
            Console.WriteLine("Hi");
        }
    }*/
    class Program
    {
        class Dog
        {
            public string name;
            public int age;
            public string color;
        }

        class Employee
        {
            private string name;
            private string gender;
            private int age;

            public Employee(string n, string g, int a)
            {
                name = n;
                gender = g;
                age = a;
            }

            public string getName()
            {
                return name;
            }
            public int getAge()
            {
                return age;
            }
            public string getGender()
            {
                return gender;
            }
        }
        static void Main(string[] args)
        {
            //class constructor
            Employee j = new Employee("John", "Male", 25);
            Console.WriteLine(j.getName());
            Console.WriteLine(j.getAge());
            Console.WriteLine(j.getGender());









            /* Person p1 = new Person();
             //p1.SayHi();

             Dog d = new Dog();
             d.name = "Drake";
             d.age = 3;
             d.color = "white";

             Console.WriteLine(d.name);
             Console.WriteLine(d.age);
             Console.WriteLine(d.color);
         */
        }
    }
}
