using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter an integer: ");                                                                                                         // Asks user for an integer
            int userChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(userChoice + " squared is: " + DoMath.Squared(userChoice));                                                                       // Displays the answer using the Squared method in the DoMath class

            Console.WriteLine(userChoice + " to the third power is: " + DoMath.Third(userChoice));                                                              // Displays the answer using the Third method in the DoMath class

            double finalCalc = DoMath.Final(userChoice);                                                                                                        // Calls the Final method in the DoMath class and sets the result to a variable

            Console.WriteLine(userChoice + " times 2 plus " + userChoice + " squared plus " + userChoice + " to the third power is: " + finalCalc);             // Displays the final answer

            Console.ReadLine();
        }
    }
}
