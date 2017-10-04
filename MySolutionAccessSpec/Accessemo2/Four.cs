using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessemo2
{
    // Case4: Consuming the members of a class from child class of different project.
    class Four : AccesDemo1.Program
    {
        static void Main(string[] args)
        {
            Four f = new Four();
            f.Test3(); f.Test4(); f.Test5();
        }
    }
}
