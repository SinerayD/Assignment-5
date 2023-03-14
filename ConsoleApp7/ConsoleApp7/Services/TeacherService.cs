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

        
    }
}
