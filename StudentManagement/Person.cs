using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Person
    {
        private static int LastId = 1;
        public int Id { get; }
        public required string Name { get; set; }
        public required string Dob { get; set; }

        public Person()
        {
            Id = LastId++;
        }

        public void Show()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Dob: " + Dob);
        }
    }
}
