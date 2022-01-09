using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Step383
{
    class Program
    {
        static void Main(string[] args)
        {
            //------------ Declare a constante for the title of the program -------------
            const string title = "--------------------------------\nThis is the Title of the Program\n--------------------------------";
            //------------ Display the title -------------
            Console.Write(title);
            //------------ Ask user for various names -------------

            Console.Write("\nPlease enter your first name: ");
            string firstName = Console.ReadLine();

            Console.Write("\nPlease enter your middle name or press enter: ");
            string middleName = Console.ReadLine();

            Console.Write("\nPlease enter your last name: ");
            string lastName = Console.ReadLine();

            //------------ Call constructor with two parameters supplied and with three -------------
            FullName name_object = new FullName(firstName, lastName);
            FullName name_object2 = new FullName(firstName, middleName, lastName);


            Console.ReadLine();
        }

    }
}
