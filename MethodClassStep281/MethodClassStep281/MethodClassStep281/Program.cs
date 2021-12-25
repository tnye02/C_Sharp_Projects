using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClassStep281
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();                       // Instantiates the class Class1

            class1.myMethod(2, 4);                              // Calls the method with just two numbers
            class1.myMethod(int1: 3, int2: 5);                  // Calls the method specifiying the parameters by name

            Console.ReadLine();
        }
    }
}
