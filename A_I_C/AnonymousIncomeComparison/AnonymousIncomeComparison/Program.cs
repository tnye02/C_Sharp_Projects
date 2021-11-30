using System;

    class Program
    {
        static void Main()
        {
        Console.WriteLine("Anonymous Income Comparison Program");                   // Program Title
        Console.WriteLine("-----------------------------------");

        Console.WriteLine("Person 1:");
        Console.WriteLine("Please enter your hourly rate:");                        // Retrieves hourly rate and hours work per week for person 1
        double p1_rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter your total hours worked per week:");
        double p1_hrs = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Person 2:");
        Console.WriteLine("Please enter your hourly rate:");                        // Retrieves hourly rate and hours work per week for person 2
        double p2_rate = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Please enter your total hours worked per week:");
        double p2_hrs = Convert.ToDouble(Console.ReadLine());

        double p1_total = p1_rate * p1_hrs * 52;                                    // Performs the necessary calculations
        double p2_total = p2_rate * p2_hrs * 52;

        Console.WriteLine("-----------------------------------");
        Console.WriteLine("Annual salary of Person 1: $" + p1_total);               // Outputs salaries for both people
        Console.WriteLine("Annual salary of Person 2: $" + p2_total);
        
        Console.ReadLine();

        }
    }

