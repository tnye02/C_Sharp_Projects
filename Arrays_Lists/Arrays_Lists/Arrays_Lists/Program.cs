using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // -------------------------------- This is the string array section --------------------------------
        
        string[] string_array = {"alpha", "beta", "gamma", "delta", "epsilon"};                                             

        Console.WriteLine("\nI have an array of 5 words, please choose an index number between 1 and 5: ");                 // Prompts the user to chose an index

        int choice = 0;                                                                                                     // Set the choice variable to zero

        while ((!int.TryParse(Console.ReadLine(), out choice)) || (choice < 1) || (choice > 5))                             // While loop to check for integer between 1 and 5
        {
            Console.WriteLine("\nThat index does not exist, please enter an index number between 1 and 5:");                // Error message prompting user to try again
        }

        Console.WriteLine("\nYou chose:" + string_array[choice - 1]);

        Console.WriteLine("\nPlease press ENTER to continue.");
        Console.ReadLine();

        // -------------------------------- This is the integer array section --------------------------------

        int[] int_array = { 55, 105, 7348, 23123, 53123 };                                                                  

        Console.WriteLine("\nI have an array of 5 integers, please choose an index number between 1 and 5: ");              // Prompts the user to chose an index

        int int_choice = 0;                                                                                                 // Set the choice variable to zero

        while ((!int.TryParse(Console.ReadLine(), out int_choice)) || (int_choice < 1) || (int_choice > 5))                 // While loop to check for integer between 1 and 5
        {
            Console.WriteLine("\nThat index does not exist, please enter an index number between 1 and 5:");                // Error message prompting user to try again
        }

        Console.WriteLine("\nYou chose:" + int_array[int_choice - 1]);

        Console.WriteLine("\nPlease press ENTER to continue.");

        // -------------------------------- This is the string list section --------------------------------

        var greek_alphabet = new List<string>()
        {
            "upsilon",
            "phi",
            "chi",
            "psi",
            "omega"
    };

        Console.WriteLine("\nI have a list of 5 more words, please choose an index number between 1 and 5: ");              // Prompts the user to chose an index

        int greek_choice = 0;                                                                                               // Set the choice variable to zero

        while ((!int.TryParse(Console.ReadLine(), out greek_choice)) || (greek_choice < 1) || (greek_choice > 5))           // While loop to check for integer between 1 and 5
        {
            Console.WriteLine("\nThat index does not exist, please enter an index number between 1 and 5:");                // Error message prompting user to try again
        }

        Console.WriteLine("\nYou chose:" + greek_alphabet[greek_choice - 1]);

        Console.WriteLine("\nPlease press ENTER to exit the program, thanks for stopping by!");

        Console.ReadLine();

    }
}
