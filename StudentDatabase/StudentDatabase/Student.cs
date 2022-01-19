using System;
using System.Collections.Generic;
using System.Text;

namespace StudentDatabase
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public decimal Height { get; set; }
        public float Weight { get; set; }

        public Grade Grade { get; set; }
    }
}
