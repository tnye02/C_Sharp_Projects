using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStep285
{
    class MyClass
    {
        public void myMethod(int int1)                                          // Method to divide an integer by 2
        {
            int answer = int1 / 2;                                              // Performs math operation
            Console.WriteLine(answer);                                          // Displays the answer     
        }

        public void myMethod(int input, out int multiplier, out int answer)     // Overloads myMethod
        {
            multiplier = 3;                                                     // Declare multiplier
            answer = input * multiplier;                                        // Math operation
        }

    }
}
