using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProject
{
    class Class1
    {
        static void Main()
        {
            int[] Arr = { 23, 34, 56, 76, 55, 54, 34, 67, 36, 78, 99, 41, 12, 34, 22, 47 };
            var Brr = from i in Arr where i > 40 orderby i descending select i;
            foreach (int x in Brr)
                Console.WriteLine(x + " ");
            Console.ReadLine(); 
        }

    }
}
