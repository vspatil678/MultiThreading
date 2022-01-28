using System.Collections.Generic;
using System.Linq;
using System;
namespace Multithreading.Linq
{
    class StudentandStandard
    {

        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>();
            studentList.Add(new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 });
            studentList.Add(new Student() { StudentID = 2, StudentName = "Steve", Age = 21, StandardID = 1 });
            studentList.Add(new Student() { StudentID = 3, StudentName = "Bill", Age = 18, StandardID = 2 });
            studentList.Add(new Student() { StudentID = 4, StudentName = "Ram", Age = 20, StandardID = 2 });
            studentList.Add(new Student() { StudentID = 5, StudentName = "Ron", Age = 21 });
            studentList.Add(new Student() { StudentID = 1, StudentName = "Arun", Age = 18, StandardID = 1 });
            studentList.Add(new Student() { StudentID = 2, StudentName = "Madhu", Age = 21, StandardID = 1 });
            studentList.Add(new Student() { StudentID = 3, StudentName = "Dango", Age = 18, StandardID = 2 });
            studentList.Add(new Student() { StudentID = 4, StudentName = "Zebra", Age = 20, StandardID = 2 });
            studentList.Add(new Student() { StudentID = 5, StudentName = "apple", Age = 21 });

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}};

            IDictionary<char, string> keyValuePairs = new Dictionary<char, string>();

            var resultByChar = studentList.OrderBy(s => s.StudentName).Select(d => new { startsWith = d.StudentName[0], names  = d});

           

            // var studentNames = studentList.Where(s => s.Age > 18 && s.StandardID > 0).Select(s => s.StudentName);

            //var studentNames = studentList.Where(s => s.StandardID > 0).OrderBy(s => s.StandardID).ThenBy(s => s.StudentName)
            //    .GroupBy(s => s.StandardID).Select(s => new { s.Key, names= s.Select(d => d.StudentName).ToList()});

            //var studentNames = studentList.GroupBy(s => s.StandardID).Select(s => new { s.Key, s});
            //foreach (var item in studentNames)
            //{
            //    System.Console.WriteLine(item.Key);
            //    foreach (var name in item.s)
            //    {
            //        System.Console.WriteLine(name.StudentName);
            //    }
            //}

            var sg = from stand in standardList
                     join stud in studentList
                     on stand.StandardID equals stud.StandardID
                     into studentGroup
                     select (new { standardName = stand.StandardName, students = studentGroup });

            //foreach (var item in sg)
            //{
            //    Console.WriteLine(item.standardName);
            //    item.students.OrderBy(s => s.StudentName).ToList().ForEach(s => Console.WriteLine(s.StudentName));
            //}

            IList<string> stringList = new List<string>() {
                    "C# Tutorials",
                    "VB.NET Tutorials",
                    "Learn C++",
                    "MVC Tutorials" ,
                    "Java"
                };

            var data = stringList.Where(s => s.Contains("Tutorials"));
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item);
            //}

            List<int> numbers = new List<int>() { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var data1 = numbers.Where(s => s > 3 || s < 7).OrderBy(s => s);

            //foreach (var item in data1)
            //{
            //    Console.WriteLine(item);
            //}

            string[] words = { "sky", "earth", "oak", "falcon" };
            var wordLens = words.Select(e => e);
            Console.WriteLine(string.Join(", ", wordLens));
        }
    }
}
