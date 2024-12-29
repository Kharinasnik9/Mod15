﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
            {
                new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"} },
                new Classroom { Students = {"Anna", "Viktor", "Vladimir"} },
                new Classroom { Students = {"Bulat", "Alex", "Galina"} }
            };

            var allStudents = GetAllStudents(classes);

            foreach (var student in allStudents)
            {
                Console.WriteLine(student);
            }
        }

        static string[] GetAllStudents(Classroom[] classes)
        {
            return classes.SelectMany(c => c.Students).ToArray();
        }

        public class Classroom
        {
            public List<string> Students = new List<string>();
        }
    }
}