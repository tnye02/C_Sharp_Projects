using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassStep281
{
    class Class1
    {
        public void myMethod (int int1, int int2)                       // Void method does not return any data
        {
            int answer = int1 * 764;                                    // Unused math operation on the first integer
            Console.WriteLine("The second integer is: " + int2);        // Displays the second integer
        }

    }
}
