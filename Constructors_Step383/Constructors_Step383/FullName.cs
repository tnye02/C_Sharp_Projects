using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Step383
{
    public class FullName
    {
        //------------ Chained constructor method -------------
        public FullName(string fName, string lName) : this(fName, "<<NO MIDDLE NAME PROVIDED>>", lName)
        {

        }

        //------------ Original constructor method (used var type instead of string) -------------
        public FullName(string fName, string midName, string lName)
        {
            var first_name = fName;
            var last_name = lName;
            var middle_name = midName;
            var full_name = fName + " " + midName + " " + lName;

            Console.WriteLine("Full name: " + full_name);
        }
    }
}
