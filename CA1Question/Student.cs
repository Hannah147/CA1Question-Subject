using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CA1Question
{
    class Student
    {
        public string Name { get; set; }
        public string DateOfBirth { get; set; }

        public List<Subject> Subjects = new List<Subject>();

        public Student(string name, string dateofbirth)
        {
            Name = name;
            DateOfBirth = dateofbirth;

            foreach (Subject subject in Subjects)
            {
                WriteLine(subject);
            }
        }

        public override string ToString()
        {
            return "Name : " + Name + "Date of Birth" + DateOfBirth;
        }
    }
}
