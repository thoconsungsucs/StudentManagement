using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Class
    {
        private static int LastId = 1;
        public string ClassId { get; set; }
        public required string ClassName { get; set; }
        public required string Subject { get; set; }
        public Teacher? Teacher { get; set; }

        public Class()
        {
            ClassId = "C" + LastId++;
        }

        public void Show()
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("ClassId: " + ClassId);
            Console.WriteLine("ClassName: " + ClassName);
            Console.WriteLine("Subject: " + Subject);
            Teacher?.Show();
            Console.WriteLine("-----------------");
        }
    }
}
