using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step313_OperatorOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();                 // Instantiate new employee object
            Employee employee2 = new Employee();                // Instantiate new employee object
            Employee employee3 = new Employee();                // Instantiate new employee object

            employee.firstName = "Bob";                         // Set first name to Bob
            employee.lastName = "Smith";                        // Set last name to Smith
            employee.emp_id = 1;

            employee2.firstName = "Bob";                        // Set first name to Bob
            employee2.lastName = "Smith";                       // Set last name to Smith
            employee2.emp_id = 1;


            employee3.firstName = "Seth";                       // Set first name to Bob
            employee3.lastName = "Roberts";                     // Set last name to Smith
            employee3.emp_id = 2;

            employee.SayName();                                 // Call SayName method on the object
            Console.ReadLine();

            if (employee.emp_id == employee2.emp_id)            // Using overridden == operator compare the two employee ids
            {
                Console.WriteLine("\nThat ID already exists.");
            }

            else
            {
                Console.WriteLine("\nAdded " + employee2.firstName + " " + employee2.lastName + " to the list. Thank you!");
            }

            if (employee2.emp_id == employee3.emp_id)           // Using overridden == operator compare the two employee ids
            {
                Console.WriteLine("\nThat ID already exists.");
            }

            else
            {
                Console.WriteLine("\nAdded " + employee3.firstName + " " + employee3.lastName + " to the list. Thank you!");
            }

            IQuittable emp_quit = employee;                 // Creates an object of type IQuittable from employee
            emp_quit.Quit();                                // Calls the Quit() Method on the object
        }
    }
}