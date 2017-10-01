using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQProject
{
    class Class2
    {
        static void Main()
        {
            int[] myArray = { 25, 45, 34, 21, 65, 36, 76, 32, 23, 54, 69, 76, 49, 50, 31, 58, 57 };

            var mArray = from i in myArray where i > 32 orderby i descending select i;
            foreach (var m in mArray)
                Console.Write(m + " ");
            Console.ReadLine();

        }
    }
}
