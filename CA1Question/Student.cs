using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CA1Question
{
    public class Student
    {
        // Question 7
        public static string Name { get; set; }
        public static string DateOfBirth { get; set; }

        public List<Subject> Subjects = new List<Subject>();

        // Question 8
        public Student(string name, string dateofbirth)
        {
            Name = name;
            DateOfBirth = dateofbirth;
        }

        // Question 9
        public override string ToString()
        {
            return "Name : " + Name + "\nDate of Birth : " + DateOfBirth;
        }
    }
}
