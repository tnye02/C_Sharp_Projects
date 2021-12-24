using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodStep280
{
    class MyMethod
    {
        public static int DoThings(int int1, int int2 = 0)                  // Method that adds two integers together with an optional second integer set to zero
        {
            int answer = int1 + int2;
            return answer;
        }
    }
}
