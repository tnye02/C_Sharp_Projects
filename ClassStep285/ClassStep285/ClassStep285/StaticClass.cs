using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStep285
{
    static class StaticClass
    {
        public static int num1 = 450;                                                                               // Declare public static integers
        public static int num2 = 4221;

        public static void staticMethod1()                                                      
        {
            Console.WriteLine("This is from a static Class:");
            Console.WriteLine("\n" + num1 + " times " + num2 + " equals " + (num1 * num2));                         // Display a sentence and calculation 
        }
    }


}
