using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var BMW320i = new BMW();
            var HONDAFit = new HONDA();

            Console.WriteLine("BMW Registration Number: {0}", BMW320i.RegistrationNumber());
            Console.WriteLine("BMW Number of Windows: {0}", BMW320i.NumberOfWindows());

            Console.WriteLine("\n\n");

            Console.WriteLine("HONDA Registration Number: {0}", HONDAFit.RegistrationNumber());
            Console.WriteLine("HONDA NumberOfWindows: {0}", HONDAFit.NumberOfWindows());

            Console.ReadKey();
        }
    }
}
