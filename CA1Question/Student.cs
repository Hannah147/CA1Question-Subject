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
        public string Name { get; set; }
        public string DateOfBirth { get; set; }

        public List<Subject> Subjects = new List<Subject>();

        public Student(string name, string dateofbirth)
        {
            Name = name;
            DateOfBirth = dateofbirth;
        }

        public override string ToString()
        {
            return "Name : " + Name + "\nDate of Birth : " + DateOfBirth;
        }


    }
}
