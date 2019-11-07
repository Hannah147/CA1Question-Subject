using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1Question
{
    class Subject
    {
        public string Name { get; set; }
        public string Lecturer { get; set; }
        public int Year { get; set; }

        public Subject(string name, string lecturer, int year)
        {
            Name = name;
            Lecturer = lecturer;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Name} {Lecturer} Year {Year}";
        }

    }
}
