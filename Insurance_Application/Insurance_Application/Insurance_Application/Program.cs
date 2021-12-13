using System;


class Program
{
    static void Main()
    {
        Console.WriteLine("Use this program to check if customer is approved for Auto Insurance");                      // Title explaining what the program does
        Console.WriteLine("--------------------------------------------------------------------");                      
        Console.WriteLine("What is your Age?");                                                                         // Asks for the users age
            
        int cust_age;                                                                                                   // Declare the variable

        while(!int.TryParse(Console.ReadLine(), out cust_age))                                                          // Checks that input is an integer
        {
            Console.WriteLine("Please enter your age as a whole number. No decimals or fractions please! - ");
        }

        bool age_check;

        if (cust_age >= 15)                                                                                             // If/else that sets a boolean depending on the users age
        {
            age_check = true;
        }
        else
        {
            age_check = false;
        }

        Console.WriteLine("Have you ever had a DUI? yes/no -");                                                         // Asks user if they've had a DUI
        string get_dui = Console.ReadLine();
        string cust_dui = get_dui.ToLower();
        while ((cust_dui != "yes") && (cust_dui != "no"))                                                               // While loop that runs until yes or no is entered regardless of case
        {
            Console.WriteLine("Please enter yes or no: ");
            get_dui = Console.ReadLine();
            cust_dui = get_dui.ToLower();
        }

        bool no_dui = false;                                                                                            // Sets a boolean depending on if the user has had a DUI
        if (cust_dui == "no")
        {
            no_dui = true;
        }
        else if (cust_dui == "yes")
        {
            no_dui = false;
        }

        Console.WriteLine("How many speeding tickets have you had?");                                                   // Asks user how many speeding tickets they've had

        int get_tix;

        while (!int.TryParse(Console.ReadLine(), out get_tix))                                                          // While loop that runs until the input is an integer
        {
            Console.WriteLine("Please enter the number of tickets as a whole number. No decimals or fractions please! - ");
        }

        bool good_tix;                                                                                                  // Sets a boolean if tickets are less than or equal to 3
        if (get_tix <= 3)
        {
            good_tix = true;
        }
        else{
            good_tix = false;
        }

        if (age_check && no_dui && good_tix)                                                                            // Checks that all requirements are met and prints out 
        {                                                                                                               // the appropriate message
            Console.WriteLine("Customer is qualified for Auto Insurance.");
            Console.WriteLine("Press enter to exit.");
        }
        else
        {
            Console.WriteLine("Customer is NOT qualified for Auto Insurance.");
            Console.WriteLine("Press enter to exit.");
        }

        Console.ReadLine();
    }
}


