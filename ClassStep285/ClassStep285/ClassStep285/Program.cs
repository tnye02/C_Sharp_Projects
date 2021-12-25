using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStep285
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();                                                                                        // Instantiation of myClass

            myClass.myMethod(50);                                                                                                   // Send integer 50 to myMethod

            Console.Write("\nPlease enter a number: ");                                                                             // Ask for an integer to divide
            Console.WriteLine("\n");
   
            Console.WriteLine("\nYour number rounded equals: " + myClass.myMethod(Convert.ToDouble(Console.ReadLine())) + "\n");    // Send user double to myMethod

            StaticClass.staticMethod1();                                                                                            // Calls static class that multiplies two numbers

            Console.ReadLine();
        }
    }
}
