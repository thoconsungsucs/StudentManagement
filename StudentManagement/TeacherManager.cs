using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class TeacherManager
    {
        public List<Teacher> Teachers { get; set; }

        public TeacherManager()
        {
            Teachers = new List<Teacher>();
        }

        public void AddTeacher(Teacher t)
        {
            Teachers.Add(t);
        }

        public void ShowTeachers()
        {
            Teachers.ForEach(t => t.Show());
        }
    }
}
