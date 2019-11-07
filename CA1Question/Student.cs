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
        }

        public override string ToString()
        {
            return "Name : " + Name + "\nDate of Birth : " + DateOfBirth;
        }

        public static void DisplayAgeInDays(string DOB)
        {
            int answer;

            string[] fields = new string[2];

            fields = DOB.Split('-');

            int year = int.Parse(fields[2]);

            int month = int.Parse(fields[1]);

            int day = int.Parse(fields[0]);

            int ageYears = 2019 - year;

            int ageMonths = 11 - month;

            answer = (year * 365) + (month * 30) + day;
        }

    }
}
