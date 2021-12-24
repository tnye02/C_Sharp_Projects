using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class MyClass
    {
        public static int DoThings(int myInteger)
        {
            int answer = (myInteger * 2) + myInteger;
            return answer;
        }

        public static double DoThings(double myDouble)
        {
            double answer = myDouble * 100;
            return answer;
        }

        public static string DoThings(string myString)
        {
            int myInt;
            try
            {
                if (int.TryParse(myString, out myInt))
                {
                    int answer = (DoThings(myInt) + 42) * 42;
                    string success = "\n" + myInt + " plus 42 times 42 equals " + answer;
                    return success;
                }
                else
                {
                    string fail = "\nSorry I could not convert " + myString + " to an integer.";
                    return fail;
                }
            }
            catch (Exception e)
            {
                string error = e.Message;
                return error;
            }

        }
    }
}
