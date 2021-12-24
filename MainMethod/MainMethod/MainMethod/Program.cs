using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an integer: ");
            int theChoice = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n" + theChoice + " times 2 plus " + theChoice + " equals " + MyClass.DoThings(theChoice));

            Console.WriteLine("\nPlease enter a decimal: ");
            double theChoice2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n" + theChoice2 + " rounded is: " + MyClass.DoThings(theChoice2));

            Console.WriteLine("\nThis will conver the string \"3456\" to an integer and multiply it by 400:");
            string theChoice3 = "3456";

            Console.WriteLine(MyClass.DoThings(theChoice3));

            Console.WriteLine("\nPlease press ENTER to exit.");
            Console.ReadLine();
        }
    }
}
