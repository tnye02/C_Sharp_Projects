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

        public static int DoThings(double myDouble)
        {
            double answer = Math.Round(myDouble);
            int ret_int = Convert.ToInt32(answer);
            return ret_int;
        }

        public static int DoThings(string myString)
        {
            int str_convert = Convert.ToInt32(myString);

            int answer = 400 * str_convert;            

            return answer;

        }
    }
}
