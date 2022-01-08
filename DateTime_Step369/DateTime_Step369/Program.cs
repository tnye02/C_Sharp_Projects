using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTime_Step369
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----------------------- Assign current date and time to a DateTime variable and display the message -----------------------
            DateTime currentDateTime = DateTime.Now;
            Console.WriteLine("The current date and time are: " + currentDateTime);

            // ----------------------- Request a number of hours from the user and assign it to an int variable -----------------------
            Console.Write("Please enter a number of hours to add to the current time: ");
            int addHours = Convert.ToInt32(Console.ReadLine());

            // ----------------------- Add the hours entered to the current time variable and assign to a new variable newDateTime -----------------------
            DateTime newDateTime = currentDateTime.AddHours(addHours);

            // ----------------------- Display the new date and time message -----------------------

            Console.WriteLine("The Date and Time in " + addHours + " hours will be " + newDateTime);
            
            Console.ReadLine();

        }
    }
}
