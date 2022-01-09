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

        //------------ Original constructor method -------------
        public FullName(string fName, string midName, string lName)
        {
            string first_name = fName;
            string last_name = lName;
            string middle_name = midName;
            string full_name = fName + " " + midName + " " + lName;

            Console.WriteLine("Full name: " + full_name);
        }
    }
}
