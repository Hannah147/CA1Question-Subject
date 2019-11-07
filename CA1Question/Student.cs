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
        public static string Name { get; set; }
        public static string DateOfBirth { get; set; }

        public List<Subject> Subjects = new List<Subject>();

        public Student(string name, string dateofbirth)
        {
            Name = name;
            DateOfBirth = dateofbirth;

                foreach (Subject subject in Subjects)
                {
                for (int counter = 0; counter < 2; counter++)
                {
                    WriteLine(subject);
                }
                }
        }

        public override string ToString()
        {
            return "Name : " + Name + "\nDate of Birth : " + DateOfBirth;
        }
    }
}
