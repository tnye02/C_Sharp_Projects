using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsStep292
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee person = new Employee();               // Instatiate new person object
            person.FirstName = "Sample";                    // Set first name property
            person.LastName = "Student";                    // Set last name property

            person.SayName();                               // Call SayName method

            Console.ReadLine();

        }
    }
}
