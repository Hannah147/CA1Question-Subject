using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA1Question
{
    public class Subject
    {
        public static string Name { get; set; }
        public static string Lecturer { get; set; }
        public static int Year { get; set; }

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
