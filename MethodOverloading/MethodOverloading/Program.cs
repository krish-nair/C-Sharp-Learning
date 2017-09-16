using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    class Program
    {
        public void Test()
        {
            Console.WriteLine("1st Metod");
        }

        public void Test(int i)
        {
            Console.WriteLine("2nd Metod");
        }

        public void Test(string s)
        {
            Console.WriteLine("3rd Metod");
        }

        public void Test(int i, string s)
        {
            Console.WriteLine("4th Metod");
        }

        public void Test(string s, int i)
        {
            Console.WriteLine("5th Metod");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test();
            p.Test(5);
            p.Test("Hello");
            p.Test(5, "times");
            p.Test("mike", 2);

        }
    }
}
