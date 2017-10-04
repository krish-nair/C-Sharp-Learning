using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accessemo2
{
    class Five
    {
        // Case5: Consuming the members of a class from non-child class of different project.
        static void Main()
        {
            AccesDemo1.Program p = AccesDemo1.Program();
            p.Test5();
        }
    }
}
