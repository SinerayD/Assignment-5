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
    }
}
