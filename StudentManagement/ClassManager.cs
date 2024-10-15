using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class ClassManager
    {
        public List<Class> Classes { get; set; }

        public ClassManager()
        {
            
        }

        public void AddClass(Class c)
        {
            Classes.Add(c);
        }

        public Class GetClassById(string classId)
        {
            return Classes.FirstOrDefault(c => c.ClassId == classId);
        }

        public void ShowAllClasses()
        {
            Classes.ForEach(c => c.Show());
        }   
    }
}
