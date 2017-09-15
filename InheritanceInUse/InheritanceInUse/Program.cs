using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInUse
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 123;
            s.Name = "Mohan";
            Console.WriteLine(s.Name);
            Console.WriteLine(s.Id);

            TeachingStaff ts = new TeachingStaff();
            ts.Id = 0071;
            ts.Name = "Raj Rai";
            Console.WriteLine("The teacher name is {0} and Id is {1}", ts.Name, ts.Id);
        }
    }
}
