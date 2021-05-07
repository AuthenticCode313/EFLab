using System;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //CreateDB();
            DisplayAllDB();
            DisplayStudentDB();

        }

        static void CreateDB()
        {
            using (var context = new ClassContext())
            {
                Student ali = new Student()
                {
                    Name = "Alice",
                    Hometown = "Detroit",
                    Food = "Sushi"
                
                };
                context.Students.Add(ali);

                Student kal = new Student()
                {
                    Name = "Kalai",
                    Hometown = "Troy",
                    Food = "Dosa"
                };
                context.Students.Add(kal);

                Student jea = new Student()
                {
                    Name = "Jean",
                    Hometown = "Lascahobas",
                    Food = "Fritay"
                };
                context.Students.Add(jea);

                Student sea = new Student()
                {
                    Name = "Sean",
                    Hometown = "Plymouth",
                    Food = "Pizza"
                };
                context.Students.Add(sea);

                Student jus = new Student()
                {
                    Name = "Justin",
                    Hometown = "Wyoming",
                    Food = "Baja Blast"
                };
                context.Students.Add(jus);

                Student jas = new Student()
                {
                    Name = "Jason",
                    Hometown = "Courtright",
                    Food = "Mac & Chesse"
                };
                context.Students.Add(jas);

                Student kris = new Student()
                {
                    Name = "Kristen",
                    Hometown = "Orange Park",
                    Food = "Macaroni and Cheese"
                };
                context.Students.Add(kris);

                Student kam = new Student()
                {
                    Name = "Kamesha",
                    Hometown = "Detroit",
                    Food = "Tacos"
                };

                context.Students.Add(kam);
               

                //Take all changes to the list and send it to the database
                context.SaveChanges();
            }

        }

        static void DisplayAllDB()
        {
            using (var context = new ClassContext())
            {
                var sts = context.Students.Where(s => s.Name == s.Name).ToList();
              
                foreach (Student student in sts)
                {
                    Console.WriteLine($"ID: {student.StudentId} Name: {student.Name}");
                }
            }
        }

        static void DisplayStudentDB()
        {
            using (var context = new ClassContext())
            {
               
                Console.WriteLine("Please enter a student ID:");
                int input = int.Parse(Console.ReadLine());

                var all = context.Students.ToList();
                foreach(Student s in all)
                {
                    if(s.StudentId == input)
                    {
                        Console.WriteLine($"Student {input}'s favorite food is {s.Food} and their hometown is {s.Hometown}.");
                    }
                }
                //Student s = new Student
                //{
                //    StudentId = input
                //};

                //var sts = context.Students.Where(s => s.StudentId == input).ToList();
                
                //foreach(var ok in sts)
                //{
                //    Console.WriteLine($"{ok.Name}'s favorite food is {ok.Food} and their hometown is {ok.Hometown}.");
                //}
                    
                
              
            }
        }
    }
}
