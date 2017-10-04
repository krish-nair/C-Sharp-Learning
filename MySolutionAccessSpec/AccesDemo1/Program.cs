﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesDemo1
{
    public class Program
    {
        private void Test1()
        {
            Console.WriteLine("Private Method");
        }
        internal void Test2()
        {
            Console.WriteLine("Internal Method");
        }
        protected void Test3()
        {
            Console.WriteLine("Protected Method");
        }
        protected internal void Test4()
        {
            Console.WriteLine("Protected Internal Method");
        }
        public void Test5()
        {
            Console.WriteLine("Public Method");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Test1(); p.Test2(); p.Test3();
            p.Test4(); p.Test5();

        }
    }
}
