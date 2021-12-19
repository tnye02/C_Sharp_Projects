using System;
using System.Text;


class Program
{
    static void Main()
    {
        Console.WriteLine("This small program will demonstrate some things you can do with strings.");                      // Introduction
        Console.WriteLine("\n------------------------------------------------------------------------");
        Console.WriteLine("Please prese ENTER to continue!");                                                               // Pause for user to press enter

        Console.ReadLine();

        Console.WriteLine("For example: \\n creates a new line like this: \nThis sentence is on a new line");               // Use escape character \n to create a new line
        Console.WriteLine("\n------------------------------------------------------------------------");
        Console.WriteLine("Please prese ENTER to continue!");                                                               // Pause for user to press enter


        Console.ReadLine();

        Console.WriteLine("You can concatenate multiple strings as well, this means to add them together:");                // Demonstrate concatination of strings
        string str_1 = "The dog is barking";
        Console.WriteLine("String 1: " + str_1);
        string str_2 = " at the black cat!";
        Console.WriteLine("String 2: " + str_2);
        Console.WriteLine("\nWhen they are concatenated, they look like this:");
        string str_3 = str_1 + str_2;
        Console.WriteLine(str_3);
        string str_4 = "The black cat hissed at the dog!";
        Console.WriteLine("\n------------------------------------------------------------------------");
        Console.WriteLine("Please prese ENTER to continue!");                                                               // Pause for user to press enter

        Console.ReadLine();

        Console.WriteLine("You can then add even more strings!");                                                           // Concatenating three strings
        Console.WriteLine("String 3: " + str_4 + "\n");
        string str_5 = str_1 + str_2 + "\n" + str_4;
        Console.WriteLine("\nWhen they are concatenated, they look like this:");
        Console.WriteLine(str_5);
        Console.WriteLine("\n------------------------------------------------------------------------");
        Console.WriteLine("Please prese ENTER to continue!");                                                               // Pause for user to press enter

        Console.ReadLine();

        Console.WriteLine("You can change the case to all upper or all lower like so:");                                    // Demonstrate ToUpper
        Console.WriteLine(str_5.ToUpper());

        Console.WriteLine("\n------------------------------------------------------------------------");
        Console.WriteLine("Please prese ENTER to continue!");                                                               // Pause for user to press enter

        Console.ReadLine();

        Console.WriteLine("You can use the StringBuilder class as well:");                                                  // Demonstrate StringBuilder by appending one string to another 
                
        StringBuilder sb1 = new StringBuilder(str_1, 50);
        sb1.Append(str_2);

        Console.WriteLine(sb1);

        Console.WriteLine("\n------------------------------------------------------------------------");
        Console.WriteLine("Thank you for your time, please prese ENTER to end the program!");                               // Pause for user to press enter

        Console.ReadLine();
    }
}
