using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Step302
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();             // Instantiate new employee object
            employee.firstName = "Bob";                     // Set first name to Bob
            employee.lastName = "Smith";                    // Set last name to Smith

            employee.SayName();                             // Call SayName method on the object
            Console.ReadLine();

        }
    }
}
