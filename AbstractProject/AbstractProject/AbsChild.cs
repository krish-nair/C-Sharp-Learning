using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    class AbsChild : AbsParent
    {
        public override void Div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
        public override void Mul(int x, int y)
        {
            Console.WriteLine(x * y);
        }
        
        static void Main()
        {
            AbsChild abc = new AbsChild();
            abc.Add(25, 50); abc.Div(40, 4);
            abc.Sub(30, 20);

            Console.ReadLine();
        }
    }
}
