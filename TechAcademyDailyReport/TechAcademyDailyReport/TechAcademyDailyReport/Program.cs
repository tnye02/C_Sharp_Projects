using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");                  //---------------
            Console.WriteLine("-----------------------------");     //  Introduction
            Console.WriteLine("Student Daily Report");              // of Daily Report
            Console.WriteLine("-----------------------------");     //---------------
            
            Console.WriteLine("What is your name? ");                   // Asks for students name
            string studentName = Console.ReadLine();                    // Declare string variable for and receive users name
                                                                        
            Console.WriteLine("What course are you currently working on?  ");   // Asks for Course Name 
            string courseName = Console.ReadLine();                             // Declare string variable for and receive users current course

            Console.WriteLine("What page number are you on?  ");        // Asks for page number
            string str_coursePage = Console.ReadLine();                 // Declare string variable for and receive users current page
            int int_coursePage = Convert.ToInt32(str_coursePage);

            Console.WriteLine("Is there anything you need help with?");     // Asks for if student needs help  
            Console.WriteLine("Please answer true or false.");              // Tells student to enter true or false  
            string str_needHelp = Console.ReadLine();                       // Declare string variable for and receive users current course

            //bool bool_needHelp = Convert.ToBoolean(str_needHelp);         // commented out for possible future use, as is no need to verify boolean data type

            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics:");   // Asks user for positive experiences
            string posExper = Console.ReadLine();                                                                   // Declare string variable for positive experiences

            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific:");    // Requests further feedback from user
            string feedback = Console.ReadLine();                                                           // Declare string variable for feedback

            Console.WriteLine("How many hours did you study today?");       // Asks student for hours studied
            float hours = float.Parse(Console.ReadLine());                  // Declare float value, no error check currently may implement later

            Console.WriteLine("Thank you for your answers.\nAn Instructor will respond to this shortly. Have a great day!");    // Closing message

        Console.ReadLine();

        }
    }

