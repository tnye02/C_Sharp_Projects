using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStep285
{
    class MyClass
    {
        public void myMethod(int int1)                                      // Method to divide an integer by 2
        {
            int answer = int1 / 2;                                          // Performs math operation
            Console.WriteLine("\n" + answer);                               // Displays the answer     
        }

        public int myMethod(double db1)                                     // Overloads the method
        {
            int response = Convert.ToInt32(db1);
            return response;
        }

    }
}
