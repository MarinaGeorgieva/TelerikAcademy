namespace StudentsAndCourses
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    using Wintellect.PowerCollections;

    public class Startup
    {
        public static void Main()
        {
            var sortedDictionary = new SortedDictionary<string, OrderedBag<Student>>();

            ReadAndParseInput(sortedDictionary);
            PrintStudentsAndCourses(sortedDictionary);
        }

        private static void PrintStudentsAndCourses(SortedDictionary<string, OrderedBag<Student>> sortedDictionary)
        {
            foreach (var pair in sortedDictionary)
            {
                Console.WriteLine("{0}: {1}", pair.Key, string.Join(", ", pair.Value));
            }
        }

        private static void ReadAndParseInput(SortedDictionary<string, OrderedBag<Student>> sortedDictionary)
        {
            using (StreamReader reader = new StreamReader("../../students.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] studentAndCourse = reader.ReadLine()
                        .Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();

                    string firstName = studentAndCourse[0];
                    string lastName = studentAndCourse[1];
                    string course = studentAndCourse[2];
                    Student student = new Student(firstName, lastName);

                    if (!sortedDictionary.ContainsKey(course))
                    {
                        sortedDictionary.Add(course, new OrderedBag<Student>());
                    }

                    sortedDictionary[course].Add(student);
                }
            }
        }
    }
}
