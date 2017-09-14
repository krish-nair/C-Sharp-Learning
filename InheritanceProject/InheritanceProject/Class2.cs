using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceProject
{
    class Class2 : Class1
    {
        public void Test()
        {
            Console.WriteLine("Method3");
        }
        static void Main()
        {


            Object obj = new Object();
                Class2 c = new Class2();
                c.Test1();
                c.Test2();
                c.Test();
            }
        }
    }
}
