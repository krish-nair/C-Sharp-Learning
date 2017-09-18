using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassExercise
{
    public class BMW : ICarModel
    {
        public string RegistrationNumber()
        {
            return "WE123";
        }
        public int NumberOfWindows()
        {
            return 4;
        }
    }
}
