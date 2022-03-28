using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace CodeFirstDB
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("Enter a student name: ");
                var name = Console.ReadLine();

                var student = new Student { Name = name };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from s in db.Students
                            orderby s.Name
                            select s;

                Console.WriteLine("All students in database: ");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Name);
                }

                Console.WriteLine("Press any key to exit. . .");
                Console.ReadKey();
            }
        }

        public class Student
        {
            public int StudentID { get; set; }
            public string Name { get; set; }
            public string URL { get; set; }

            public virtual List<Assignment> Assignments { get; set; }
        }

        public class Assignment
        {
            public int AssignmentID { get; set; }
            public string Title { get; set; }
            public string Content { get; set; }

            public int StudentID { get; set; }
            public virtual Student Student { get; set; }
        }

        public class User
        {
            [Key]
            public string Username { get; set; }
            public string DisplayName { get; set; }
        }

        public class StudentContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<Assignment> Assignments { get; set; }
            public DbSet<User> Users { get; set; }
        }
    }
}
