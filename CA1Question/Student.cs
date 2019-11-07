using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1Question
{
    class Student
    {
        public string Name { get; set; }
        public string DateOfBirth { get; set; }

        public List<Subject> Subjects;

        public Student(string name, string dateofbirth)
        {
            Name = name;
            DateOfBirth = dateofbirth;
        }
    }
}
