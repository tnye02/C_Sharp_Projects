using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsStep292
{
    public class Person                                                             // Create public class person
    {
        public string FirstName { get; set; }                                       // Create first name variable
        public string LastName { get; set; }                                        // Create last name variable

        public void SayName()                                                       // SayName method for output
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }
    }
}
