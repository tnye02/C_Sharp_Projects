using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class DoMath
    {
        public static double Squared(double number)
        {
            double choiceSquared = Math.Pow(number, 2);                                                 // Finds the square of the input and returns the result to the Main method
            return choiceSquared;
        }

        public static double Third(double number)                                                       // Finds the third power of the input and returns the result to the Main method
        {
            double choiceThird = Math.Pow(number, 3);
            return choiceThird;
        }

        public static double Final(double number)                                                       // Does the custom calculation required and returns the result to the Main method
        {
            double choiceFinal = (number * 2) + DoMath.Squared(number) + DoMath.Third(number);
            return choiceFinal;
        }

    }
}
