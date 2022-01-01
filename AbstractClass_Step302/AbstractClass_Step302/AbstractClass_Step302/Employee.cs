using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass_Step302
{
    public class Employee : Person                                                      // Declare public class that inherits from the Person class
    {
        public override void SayName()                                                  // Declare SayName method that overrides abstract SayName method in Person class
        {
            Console.WriteLine("Employee Name: " + firstName + " " + lastName);          // Output employee name to screen
        }
    }
}
