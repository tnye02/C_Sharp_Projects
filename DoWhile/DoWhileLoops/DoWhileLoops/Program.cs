using System;

class Program
{
    static void Main()
    {
        bool running_1 = true;

        while (running_1)                                                                       // Outer while loop
        {
            Console.WriteLine("The program is running!");                                   
            Console.WriteLine("Should I exit? Yes/No");
            Console.WriteLine("If you stick around i'll show you a DO/WHILE loop!");            // Ask user if they want to exit
            string ask_exit = Console.ReadLine();
            string LC_exit = ask_exit.ToLower();

            while (LC_exit != "yes" && LC_exit != "no")                                         // Forces user to enter yes or no
            {
                Console.WriteLine("Please enter Yes or No!");
                ask_exit = Console.ReadLine();
                string v = ask_exit.ToLower();
                LC_exit = v;
            }

            if (LC_exit == "yes")
            {
                Console.WriteLine("Ok, have a nice day! The program will now exit!");           // Exits the program if user prefers
                Console.ReadLine();
                running_1 = false;
            }
            else
            {
                Console.WriteLine("Ok great! Take a look at this DO/WHILE Loop!");              // If user does not want to exit, enters the do/while loop
                bool running_2 = true;
                do                                                                              // Beginning of Do/While Loop
                {
                    Console.WriteLine("Would you like me to exit now? Yes/No");                 // Asks if user wants to exit, loops if they say no
                    string ask_exit2 = Console.ReadLine();
                    string LC_exit2 = ask_exit2.ToLower();

                    while (LC_exit2 != "yes" && LC_exit2 != "no")                               // Forces user to enter yes or no
                    {
                        Console.WriteLine("Please enter Yes or No!");
                        ask_exit2 = Console.ReadLine();
                        string v2 = ask_exit2.ToLower();
                        LC_exit2 = v2;
                    }

                    if (LC_exit2 == "yes")
                    {
                        Console.WriteLine("Ok, have a nice day! The program will now exit!");   // Exits the program
                        Console.ReadLine();
                        running_2 = false;
                        running_1 = false;
                    }

                }

                while (running_2 == true) ;                                                     // While condition
            }


        }

    }
}

