using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesDemo1
{
    // Case3: Consuming the members of a class from non-child class of same project.
    class Three
    {
        static void Main()
        {
            Program p = new Program();
            p.Test2(); p.Test4(); p.Test5();
            Console.ReadLine();
        }
    }
}
