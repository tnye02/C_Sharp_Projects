using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Step337
{
    class Program
    {
        static void Main(string[] args)
        {

            //---------------------------------- Declare and populate the base employee list ----------------------------------
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { Emp_ID = 1, Fname = "Bob", Lname = "Smith" },
                new Employee() { Emp_ID = 2, Fname = "Sarah", Lname = "Mahoney" },
                new Employee() { Emp_ID = 3, Fname = "Reggie", Lname = "Blanksly" },
                new Employee() { Emp_ID = 4, Fname = "Joe", Lname = "Esperanda" },
                new Employee() { Emp_ID = 5, Fname = "Jimmenly", Lname = "Shmrendantala" },
                new Employee() { Emp_ID = 6, Fname = "Jern", Lname = "Clemfrenz" },
                new Employee() { Emp_ID = 7, Fname = "Joe", Lname = "Rejemberd" },
                new Employee() { Emp_ID = 8, Fname = "Grednel", Lname = "Shrelnd" },
                new Employee() { Emp_ID = 9, Fname = "Jreff", Lname = "Fleim" },
                new Employee() { Emp_ID = 10, Fname = "Yelgb", Lname = "Sfembrend" }
            };

            //---------------------------------- Declare and populate a list of employees named Joe using a foreach loop ----------------------------------
            Console.WriteLine("Using a foreach loop: ");
            var joeEmployees1 = new List<Employee>();
            foreach (Employee person in employees)
            {
                if (person.Fname == "Joe")
                {
                    joeEmployees1.Add(person);
                    Console.WriteLine("Added: " + person.Fname + " " + person.Lname + " to the list of employees named Joe.");
                }
            }

            //---------------------------------- Declare and populate a list of employees named Joe using Lambda expressions ----------------------------------
            Console.WriteLine("\nUsing lambda expressions: ");

            List<Employee> joeEmployees2 = employees.FindAll(e => e.Fname == "Joe");
            joeEmployees2.ForEach(n => Console.WriteLine("Added: " + n.Fname + " " + n.Lname + " to the list of employees named Joe."));

            //---------------------------------- Declare and populate a list of employees with employee ID numbers greater than 5 ----------------------------------
            Console.WriteLine("\nList of employees with employee ID greater than 5:");

            List<Employee> empIDFiveOrMore = employees.FindAll(e => e.Emp_ID > 5);
            empIDFiveOrMore.ForEach(n => Console.WriteLine("Employee ID: " + n.Emp_ID + " Name: " + n.Fname + " " + n.Lname));

            Console.ReadLine();
        }

            //---------------------------------- Declare Employee class and its parameters ----------------------------------
        public class Employee
        {
            public int Emp_ID { get; set; }
            public string Fname { get; set; }
            public string Lname { get; set; }
        }
    }
}
