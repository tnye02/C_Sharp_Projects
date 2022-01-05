using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Step313_OperatorOverload
{
    public class Employee : Person, IQuittable                                          // Declare public class that inherits from the Person class and IQuittable Interface
    {

        public int emp_id;

        public override void SayName()                                                  // Declare SayName method that overrides abstract SayName method in Person class
        {
            Console.WriteLine("Employee Name: " + firstName + " " + lastName);          // Output employee name to screen
        }

        public void Quit()                                                              // Implements the Quit() Method from interface IQuittable
        {
            Console.WriteLine("\n" + firstName + " " + lastName + " says: ");
            Console.WriteLine("\nI quit!");
            Console.ReadLine();
        }

        public static bool operator ==(Employee emp_id1, Employee emp_id2)
        {
            bool emp_equal;
            if (emp_id1 == emp_id2)
            {
                emp_equal = true;
                return emp_equal;
            }
            else
            {
                emp_equal = false;
                return emp_equal;
            }
        }

        public static bool operator !=(Employee emp_id1, Employee emp_id2)
        {
            bool emp_NotEqual;
            if (emp_id1 != emp_id2)
            {
                emp_NotEqual = true;
                return emp_NotEqual;
            }
            else
            {
                emp_NotEqual = false;
                return emp_NotEqual;
            }
        }
    }
}