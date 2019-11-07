﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CA1Question
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Subject subject1 = new Subject("Programming", "Vivion Kinsella", 1);
            Subject subject2 = new Subject("Databases", "Padraig Harte", 1);
            Subject subject3 = new Subject("UX Design", "Adrian Durcan", 2);
            Subject subject4 = new Subject("OOP", "Keith McManus", 2);

            List<Subject> Subjects = new List<Subject>();

            Subjects.Add(subject1);
            Subjects.Add(subject2);
            Subjects.Add(subject3);
            Subjects.Add(subject4);

            Student student1 = new Student("Joe Smith", "21/10/2000");
            Student student2 = new Student("Jane Brown", "15/03/1998");

            WriteLine($"{student1} \n{subject1} \n{subject2}");

            WriteLine($"\n{student2} \n{subject3} \n{subject4}");

            WriteLine($"\nJoe Smith is {DisplayAgeInDays("21/10/2000")} days old");

            WriteLine($"\nJane Brown is {DisplayAgeInDays("15/03/1998")} days old");
            
        }

        public static int DisplayAgeInDays(string DOB)
        {
            int answer;

            string[] fields = new string[3];

            fields = DOB.Split('/');

            int year = int.Parse(fields[2]);

            int month = int.Parse(fields[1]);

            int day = int.Parse(fields[0]);

            int ageYears = 2019 - year;

            int ageMonths = 11 - month;

            answer = (ageYears * 365) + (ageMonths * 30) + day;

            //WriteLine("\nJoe Smith is {0} days old", answer);

            return answer;
        }


    }
}
