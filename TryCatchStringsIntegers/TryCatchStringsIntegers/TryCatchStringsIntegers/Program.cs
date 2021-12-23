using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        try                                                                                                                     // Enter the try/catch/finally block
        {
            var numbers = new List<int>()                                                                                       // Declare and instantiate the integer list
            {
                12,
                32,
                24,
                83,
                94,
                105
            };

            Console.WriteLine("Here is a list of integers:");

            for (int i = 0; i < numbers.Count; i++)                                                                             // For loop to display the numbers
            {
                Console.WriteLine(numbers[i]);
            }

            Console.WriteLine("Please enter an integer that you would like to divide these numbers by:");                       // Retrieve user input

            double choice = Convert.ToDouble(Console.ReadLine());

            for (int i = 0; i < numbers.Count; i++)                                                                             // For loop to calculate and display the answers
            {
                double answer = numbers[i] / choice;
                Console.WriteLine(numbers[i] + " Divided by " + choice + " Equals " + answer + ".");
            }
        }

        catch(Exception e)                                                                                                      // Catch block that prints out the error message
        {
            Console.WriteLine("\n" + e.Message);
        }

        finally                                                                                                                 // Finally block lets us know the try/catch block is exited
        {
            Console.WriteLine("\nProgram has exited the try/catch block.");
        }

        Console.ReadLine();

    }
}

