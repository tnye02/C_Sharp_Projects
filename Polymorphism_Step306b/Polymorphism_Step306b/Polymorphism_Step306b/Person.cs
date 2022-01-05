using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Step306b
{
    public abstract class Person                            // Declare abstract class that can not be an object on its own
    {
        public string firstName { get; set; }               // Declare first name variable
        public string lastName { get; set; }                // Declare last name variable
        public abstract void SayName();                     // Declare abstract method for use in all inheriting classes

    }
}