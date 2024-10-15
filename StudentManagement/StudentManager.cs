using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    internal class StudentManager
    {
        public List<Student> Students { get; set; }

        public StudentManager()
        {
            Students = new List<Student>();
        }

        public void ShowAllStudents()
        {
            Students.ForEach(s => s.Show());
        }

        public void AddStudent(Student s)
        {
            Students.Add(s);
        }

        public Student GetStudentById(int studentId)
        {
            return Students.FirstOrDefault(s => s.Id == studentId);
        }

        public void DeleteStudent(int studentId)
        {
            var student = GetStudentById(studentId);
            if (student != null)
            {
                Students.Remove(student);
            } else
            {
                Console.WriteLine("Not found");
            }
        }
    }
}
