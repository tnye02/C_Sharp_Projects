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

            Console.Write("Please enter a number: ");                                                                               // Ask for an integer to divide

            string userNumber = Console.ReadLine();
            int userInt = Convert.ToInt32(userNumber);
            
            Console.Write("\nYour number divided by two equals: ");                                                                 
            myClass.myMethod(userInt);                                                                                              // Calls first myMethod

            Console.WriteLine("\nPlease press enter to continue.");
            Console.ReadLine();

            int myMulti;                                                                                                            // Set up variables for overloaded myMethod
            int myAnswer;

            myClass.myMethod(userInt, out myMulti, out myAnswer);                                                                   // Calls overloaded myMethod
            Console.WriteLine("Your number (" + userInt + ") times " + myMulti + " equals " + myAnswer);                            // Output

            Console.WriteLine("\nPlease press enter to continue.");
            Console.ReadLine();

            StaticClass.staticMethod1();                                                                                            // Calls static class that multiplies two numbers

            Console.ReadLine();
        }
    }
}
