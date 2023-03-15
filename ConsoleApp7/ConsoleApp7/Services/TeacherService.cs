using ConsoleApp7.Interfaces;
using ConsoleApp7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Services
{
    internal class TeacherService : ITeacherService
    {
        Teacher[] Teachers = { };

        public string Surname { get; private set; }

        public void Create()
        {
            Teacher Teacher = new Teacher();

            Console.WriteLine("Enter Name : ");
            Teacher.Name = Console.ReadLine();

            Console.WriteLine("Enter surname :");
            Teacher.Surname = Console.ReadLine();

            Console.WriteLine("Enter GroupNo :");
            Teacher.GroupNo = Console.ReadLine();

        }

        internal void GetById()
        {
            Console.WriteLine("Enter Id: ");
            int Id = int.Parse(Console.ReadLine());

            foreach (Teacher Teacher in Teachers)
            {
                if (Teacher.Id == Id)
                {
                    Console.WriteLine(Id);
                }
            }
        }


        public void Show()
        {
            foreach (Teacher Teachers in Teachers)
            {
                Console.WriteLine(Teachers);

            }
        }

        public void Delete()
        {
            Console.WriteLine("Please add Id");

            int.TryParse(Console.ReadLine(), out int id);

            for (int i = 0; i < Teachers.Length; i++)
            {
                if (Teachers[i].Id == id)
                {
                    Teacher Teacher = Teachers[Teachers.Length - 1];

                    Teachers[Teachers.Length - 1] = Teachers[i];

                    Array.Resize(ref Teachers, Teachers.Length - 1);

                    Teachers[i] = Teacher;

                    return;
                }
            }
            Console.WriteLine($"Student Id No {id}. is not found");
        }

        public void Update()
        {
            Teacher Teacher = new Teacher();
            Console.WriteLine("Please add Id");

            int.TryParse(Console.ReadLine(), out int id);

            for (int i = 0; i < Teachers.Length; i++)
            {
                if (Teachers[i].Id == id)
                {
                    Console.WriteLine("Name");
                    string name = Console.ReadLine();

                    while (name.Length is > 2 and < 31)
                    {
                        Console.WriteLine("Name is not valid");

                        Teacher.Name = Console.ReadLine();
                    }
                    Teachers[i].Name = name;

                    Console.WriteLine("Surname");

                    Teacher.Surname = Console.ReadLine();


                    while (Surname.Length is > 2 and < 31)
                    {
                        Console.WriteLine("Surname is not valid");

                        Teacher.Surname = Console.ReadLine();
                    }
                    Teachers[i].Surname = Surname;

                    Console.WriteLine("Groupno");

                    string GroupNo = Console.ReadLine();
                    while (string.IsNullOrWhiteSpace(GroupNo))
                    {
                        Console.WriteLine("GroupNo is not valid");
                        GroupNo = Console.ReadLine();
                        Teachers[i].GroupNo = GroupNo;
                    }

                    return;
                }
            }
                  Console.WriteLine($"Student Id No {id}. is not found");





        }      
  
    }
           
}
            

        