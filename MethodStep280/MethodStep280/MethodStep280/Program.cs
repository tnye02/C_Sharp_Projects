using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodStep280
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt1;
            int myInt2;
            Console.WriteLine("Please enter one or two integers.  \nThe second one is optional and defaults to zero.");         // Instructions to user
            Console.Write("Integer 1: ");
            myInt1 = Convert.ToInt32(Console.ReadLine());                                                                       // User inputs integer 1

            Console.Write("Would you like to skip the second integer? y/n: ");                                                  // Ask the user if they want to enter the second integer
            string getChoice = Console.ReadLine();

            string lowerChoice = getChoice.ToLower();

            while (lowerChoice != "y" && lowerChoice != "n")                                                                    // While loop that only allows y or n    
            {
                Console.Write("Please enter y or n: ");
                getChoice = Console.ReadLine();
                lowerChoice = getChoice.ToLower();
            }

            if (lowerChoice == "y")                                                                                             // If statement branches to either possibility
            {
                MyMethod.DoThings(myInt1);
                Console.WriteLine("\nAdding your number to zero yields: " + MyMethod.DoThings(myInt1));
            }
            else
            {
                Console.Write("Integer 2: ");
                myInt2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\nAdding your two numbers together yields: " + MyMethod.DoThings(myInt1, myInt2));
            }

            Console.WriteLine("Press enter to exit.");
            Console.ReadLine();
        }
    }
}
