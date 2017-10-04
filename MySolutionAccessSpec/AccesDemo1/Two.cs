using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesDemo1

    // Case3: Consuming the members of a class from child class of same project.
class Two : Program
    {
        static void Main()
        {
            Two t = new Two();
            t.Test2(); t.Test3(); t.Test4();
            t.Test5();
        }
        
    }
}
