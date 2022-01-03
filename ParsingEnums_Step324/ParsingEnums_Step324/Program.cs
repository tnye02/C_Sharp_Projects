using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums_Step324
{        
    enum DaysOfTheWeek                                                      // Declare enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    class Program
    {
        static void Main(string[] args)
        {
            bool notDay = true;                                             // Declare boolean for while loop

            string userInput;                                               // Declare string variable for use input

            Console.WriteLine("Please enter the day of the week: ");        // Request input from user
            
            while (notDay)                                                  // Begin while loop
            {

                try                                                         // Try/catch block
                {                    
                    userInput = Console.ReadLine();                         // Recieve user input

                    DaysOfTheWeek days = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput, true);     // Enum parsing method using boolean attribute that ignores case
                    if (Enum.IsDefined(typeof(DaysOfTheWeek), days))                                            // If statement that checks if the variable is part of the enum
                    {
                        Console.WriteLine("You entered: " + days + "\nThank you!");                             // Thanks the user if they entered a day.
                        notDay = false;                                                                         // Sets while loop check boolean to false
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Please enter an actual day of the week: ");                              // Catch block that asks user for an actual day of the week and restarts while loop
                }
            }

            Console.ReadLine();
        }


    }
}
