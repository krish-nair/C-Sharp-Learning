using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarClassExercise
{
    public class HONDA : ICarModel
    {
        public string RegistrationNumber()
        {
            return "FWEF33";
        }
        public int NumberOfWindows()
        {
            return 2;
        }

    }
}