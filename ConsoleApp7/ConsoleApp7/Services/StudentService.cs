using ConsoleApp7.Interfaces;
using ConsoleApp7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Services
{
    internal class StudentService : IStudentService
    {
        Student[] Students = { };
        
        public void Create()
        {
            Student student = new Student(); 
            
            Console.WriteLine("Enter Name : ");
            student.Name = Console.ReadLine();

           
            Console.WriteLine("Enter Surname :");
             student.Surname = Console.ReadLine();

            

            Console.WriteLine("Enter GroupNo :");
            student.GroupNo = Console.ReadLine();

            
            Array.Resize(ref Students, Students.Length+1);
            Students[Students.Length - 1] = student;
        }

        internal void GetById()
        {
            Console.WriteLine("Enter Id: ");
            int Id = int.Parse(Console.ReadLine());
            foreach (Student student in Students)
            {
                if (student.Id == Id)
                {
                    Console.WriteLine(Id);
                }
            }
        }

        public void Show()
        {
            foreach(Student student in Students)
            {
                Console.WriteLine(student);
            }
            
        }

        public void Delete()
        {
            Console.WriteLine("Please add Id");

            int.TryParse(Console.ReadLine(), out int id);

            for(int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    Student Student = Students[Students.Length - 1];

                    Students[Students.Length - 1] = Students[i];

                    Array.Resize(ref Students,Students.Length-1);

                    Students[i] = Student;

                    return;
                }
            }
            Console.WriteLine($"Student Id No {id}. is not found"); 
        }

        public void Update()
        {
            Student student = new Student();
            Console.WriteLine("Please add Id");

            int.TryParse(Console.ReadLine(), out int id);

            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    Console.WriteLine("Name");
                    string name = Console.ReadLine();

                    while(name.Length is > 2 and < 31)
                    {
                        Console.WriteLine("Name is not valid");

                        student.Name=Console.ReadLine();
                    }
                    Students[i].Name = name;

                    Console.WriteLine("Surname");

                    string Surname = Console.ReadLine();


                    while (Surname.Length is > 2 and < 31)
                    {
                        Console.WriteLine("Surname is not valid");

                        Surname = Console.ReadLine();
                    }
                    Students[i].Surname = Surname;

                    Console.WriteLine("Groupno");

                    string GroupNo = Console.ReadLine();
                    while(string.IsNullOrWhiteSpace(GroupNo))
                    {
                        Console.WriteLine("GroupNo is not valid");
                        GroupNo = Console.ReadLine();
                        Students[i].GroupNo = GroupNo;
                    }

               
                    return;
                }
            }
             Console.WriteLine($"Student Id No {id}. is not found");
        }
    }
}
