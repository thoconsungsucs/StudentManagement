using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student : Person
    {
        public required string Address { get; set; }
        public Class? Class { get; set; }

        public new void Show()
        {
            base.Show();
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Class: " + Class?.ClassName);
        }
    }
}
