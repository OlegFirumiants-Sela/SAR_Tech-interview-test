using System;
using System.Collections.Generic;
using System.Linq;

namespace SecondQuestion
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
            {
                new Student{ Name = "John Smith", Age = 21, Country = "USA", Class="Math", Teacher="Mr Nerd" },
                new Student{ Name = "Ian Gilian", Age = 28, Country = "UK", Class="History", Teacher="Mr Zeus" },
                new Student{ Name = "Lisa Simpson", Age = 17, Country = "Usa", Class="Music", Teacher="Mrs Melody" },
                new Student{ Name = "Marian Yosifovitz", Age = 24, Country = "Poland", Class="Economics", Teacher="Mr Wolf" },
                new Student{ Name = "John Doe", Age = 20, Country = "Brazil", Class="Dance", Teacher="Mr Awesome" },
                new Student{ Name = "Billie Jean", Age = 21, Country = "Ireland", Class="Music", Teacher="Ms Melody" },
                new Student{ Name = "Will Smith", Age = 22, Country = "USA", Class="Drama", Teacher="Mr Spielberg" },
                new Student{ Name = "Alex Ivanov", Age = 21, Country = "Ukraine", Class="Math", Teacher="Mr Nerd" },
                new Student{ Name = "Lilly Chan", Age = 21, Country = "China", Class="Chemistry", Teacher="Mrs Acid" },
                new Student{ Name = "Bibi Nat", Age = 29, Country = "Israel", Class="History", Teacher="Mr Zeus" },
                new Student{ Name = "Bobby Brown", Age = 21, Country = "UsA", Class="Music", Teacher="Mr Drum" },
                new Student{ Name = "Angie Richards", Age = 20, Country = "USa", Class="Music", Teacher="Mr Drum" }
            };

            int numOfUsaStudents = students.Count(s => s.Country.ToUpper() == "USA");
            int numOfStudentsBetweenAge20And28 = students.Count(s => s.Age > 20 && s.Age < 28);
            var nationsOfStudentsWhoLearnHistory = (from s in students
                                                    where s.Class == "History"
                                                    select s.Country).ToList();
            var notMrDrumsMusicStudents = (from s in students
                                           where s.Class == "Music" && s.Teacher != "Mr Drum"
                                           select s.Name).ToList();


            Console.WriteLine("====== Num Of Students From USA =====\n\n");
            Console.WriteLine(numOfUsaStudents);
            Console.WriteLine("\n\n====== Num Of Student Between Ages 20 and 28 =====\n\n");
            Console.WriteLine(numOfStudentsBetweenAge20And28);
            Console.WriteLine("\n\n====== Nations Of Students Who Learn History =====\n\n");
            foreach (var s in nationsOfStudentsWhoLearnHistory)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("\n\n====== Not Mr Drums Music Students =====\n\n");
            foreach (var s in notMrDrumsMusicStudents)
            {
                Console.WriteLine(s);
            }
        }
    }
}
