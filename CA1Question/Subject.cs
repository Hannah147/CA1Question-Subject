using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1Question
{
    public class Subject
    {
        // Question 3
        public string Name { get; set; }
        public string Lecturer { get; set; }
        public int Year { get; set; }

        // Question 4
        public Subject(string name, string lecturer, int year)
        {
            Name = name;
            Lecturer = lecturer;
            Year = year;
        }

        // Question 5
        public override string ToString()
        {
            return $"{Name} {Lecturer} Year {Year}";
        }

    }
}
