using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");                         // Introduction
            Console.WriteLine("-----------------------------------------------------------------");

            Console.WriteLine("Please enter the package weight:");                                                          // Receive package weight

            int weight;

            while (!int.TryParse(Console.ReadLine(), out weight))                                                           // Checks that input is an integer
            {
                Console.WriteLine("Please enter the weight as a whole number.");
                Console.WriteLine("Round up to the nearest pound, no decimals or fractions please! - ");
            }

            string weight_check = weight > 50 ? "Package too heavy to be shipped via Package Express. Have a good day." : "Thank you!";     // Ternary operation 
            if (weight > 50)                                                                                                // If statement that exits if package is over 50 lbs
            {
                Console.WriteLine(weight_check);
                Console.ReadLine();
                System.Environment.Exit(0);
            }

            Console.WriteLine(weight_check);

            Console.WriteLine("Please enter the package width:");
            int width;
            while (!int.TryParse(Console.ReadLine(), out width))                                                          // Checks that input is an integer
            {
                Console.WriteLine("Please enter the width as a whole number.");
                Console.WriteLine("Round up to the nearest inch, no decimals or fractions please! - ");
            }

            Console.WriteLine("Please enter the package height:");
            int height;
            while (!int.TryParse(Console.ReadLine(), out height))                                                          // Checks that input is an integer
            {
                Console.WriteLine("Please enter the height as a whole number.");
                Console.WriteLine("Round up to the nearest inch, no decimals or fractions please! - ");
            }

            Console.WriteLine("Please enter the package length:");
            int length;
            while (!int.TryParse(Console.ReadLine(), out length))                                                          // Checks that input is an integer
            {
                Console.WriteLine("Please enter the length as a whole number.");
                Console.WriteLine("Round up to the nearest inch, no decimals or fractions please! - ");
            }

            int total_dim = width + height + length;

            string total_msg = total_dim > 50 ? "Package too big to be shipped via Package Express." : "Thank you!";        // Ternary operation

            if (total_dim > 50)                                                                                             // If statement that exits if package is over 50 lbs
            {
                Console.WriteLine(total_msg);
                Console.ReadLine();
                System.Environment.Exit(0);
            }
            
            Console.WriteLine(total_msg);

            int charge = ((width * height * length) * weight) / 100;                                                        // Calculates the total charge

            Console.WriteLine("Your estimated total for shipping this package is: $" + charge + ".00");
            Console.WriteLine("Thank you!");
            Console.ReadLine();


    }
}

