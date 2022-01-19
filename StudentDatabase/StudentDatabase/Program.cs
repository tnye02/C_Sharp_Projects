using System;

namespace StudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {

            using (var ctx = new SchoolContext())
            {
                var stud = new Student() { StudentName = "Terry", DateOfBirth = DateTime.ParseExact("10/06/1979", "MM/dd/yyyy", null), Height = 5.92m, Weight = 160  };

                ctx.Students.Add(stud);
                ctx.SaveChanges();
            }
        }
    }
}
