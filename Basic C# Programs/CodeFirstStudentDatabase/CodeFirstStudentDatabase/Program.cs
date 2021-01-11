using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;

namespace CodeFirstStudentDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var db = new StudentContext())
            {
                Console.WriteLine("Create a new student entry. \nPlease enter student's first name:");
                var firstName = Console.ReadLine();

                Console.WriteLine("Enter student's last name:");
                var lastName = Console.ReadLine();

                Console.WriteLine("Enter student's ID:");
                var studentID = Convert.ToInt32(Console.ReadLine());

                var student = new Student { FName = firstName, LName = lastName, StudentID = studentID };
                db.Students.Add(student);
                db.SaveChanges();

                var query = from s in db.Students
                            orderby s.LName
                            select s;

                foreach(var entry in query)
                {
                    Console.WriteLine(entry.FName, entry.LName, entry.StudentID);
                }
            }
        }

        public class Student
        {
            public string FName { get; set; }
            public string LName { get; set; }
            public int StudentID { get; set; }
        }

        public class Post
        {
            public virtual Student Student { get; set; }
        }

        public class User
        {
            [Key]
            public string UserName { get; set; }
            public string DisplayName { get; set; }
        }

        public class StudentContext : DbContext
        {
            public DbSet<Student> Students { get; set; }
            public DbSet<User> Users { get; set; }

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
                modelBuilder.Entity<User>().
                    Property(u => u.DisplayName).
                    HasColumnName("display_name");
            }
        }
    }
}
