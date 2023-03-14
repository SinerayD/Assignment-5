using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7.Models
{
    internal abstract class Person
    {
        public readonly int Id;
        private static int _count = 0;
        

        string _name;
        string _surname;
        string _groupNo;
        public string Name
        {
            get => _name;
            set
            {
                if (value.Length > 2 && value.Length < 31)
                {
                    _name = value;
                }
                else
                {
                    Console.WriteLine("Please enter min 3, max 30 character");
                }
                

                
            }
        }
        public string Surname
        {
            get => _surname;
            
            set
            {
                if (value.Length > 2 && value.Length < 31)
                {
                    _surname = value;
                }
                else
                {
                    Console.WriteLine("Please enter min 3, max 30 character");
                }
            }
        }
        public string GroupNo
        {
            get=>_groupNo;
            set
            {
                if(!string.IsNullOrWhiteSpace(value))
                {
                   _groupNo = value;
                }
            }
        }

        public Person()
        {
            _count++;
            Id=_count;
        }

        public override string ToString()
        {
            return $"Name : {Name} , Surname : {Surname} , GroupNO : {GroupNo},Id: {Id}";

        }
    }
}
