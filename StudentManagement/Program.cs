using StudentManagement;

namespace ConsoleApp1
{
    public class Program
    {
        static ClassManager ClassManager = new ClassManager();
        static StudentManager StudentManager = new StudentManager();
        static TeacherManager TeacherManager = new TeacherManager();

        public void Init()
        {
            Teacher teacher1 = new Teacher
            {
                Name = "Nguyen Van A",
                Dob = "01/01/1990",
            };

            Teacher teacher2 = new Teacher
            {
                Name = "Nguyen Van B",
                Dob = "01/01/1991",
            };
            TeacherManager.AddTeacher(teacher1);

            TeacherManager.AddTeacher(teacher2);

            ClassManager.AddClass(new Class
            {
                ClassName = "C1908G",
                Subject = "C#",
                Teacher = teacher1
            });

            ClassManager.AddClass(new Class
            {
                ClassName = "C1908I",
                Subject = "Java",
                Teacher = teacher2
            });
        }

        public static void ShowMenu()
        {
            Console.WriteLine("1. Show all students");
            Console.WriteLine("2. Add student");
            Console.WriteLine("3. Change student's information");
            Console.WriteLine("4. Delete student");
            Console.WriteLine("5. Sort student list following name");
            Console.WriteLine("6. Search student by Id");
            Console.WriteLine("7. Exit");
        }

        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                ShowMenu();
                Console.Write("Choose an option: ");
                int option = int.Parse(Console.ReadLine());

                switch(option)
                {
                    case 1:
                        ShowAllStudents();
                        break;
                    case 2:
                        AddStudent();
                        break;
                    case 3:
                        ChangeStudentInformation();
                        break;
                    case 4:
                        DeleteStudent();
                        break;
                    case 5:
                        SortStudentList();
                        break;
                    case 6:
                        SearchStudentById();
                        break;
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("Invalid option");
                        break;
                }
            }
        }

        private static void SearchStudentById()
        {
            Console.WriteLine("Enter student's id: ");
            int id = int.Parse(Console.ReadLine());
            Student s = StudentManager.GetStudentById(id);
            if (s == null)
            {
                Console.WriteLine("Student not found");
            }
            else
            {
                s.Show();
            }
        }

        private static void SortStudentList()
        {
            var sortedStudentList = StudentManager.Students.OrderBy(s => s.Name).ToList();
            sortedStudentList.ForEach(s => s.Show());
        }

        private static void DeleteStudent()
        {
            Console.WriteLine("Enter student's id: ");
            int id = int.Parse(Console.ReadLine());
            StudentManager.DeleteStudent(id);
        }

        private static void ChangeStudentInformation()
        {
            Student? s = null;
            while (s == null)
            {
                Console.Write("Enter student's id: ");
                int id = int.Parse(Console.ReadLine());
                s = StudentManager.GetStudentById(id);

                if (s == null)
                {
                    Console.WriteLine("Student not found. Please try again.");
                }
            }

            Console.Write("Enter student's name: ");
            s.Name = Console.ReadLine();
            Console.WriteLine("Enter student's dob: ");
            s.Dob = Console.ReadLine();
            Console.WriteLine("Enter student's address: ");
            s.Address = Console.ReadLine();
            Console.WriteLine("Enter class id: ");
            ClassManager.ShowAllClasses();
            string classId = Console.ReadLine();
            Class c = ClassManager.GetClassById(classId);
            s.Class = c;
        }

        private static void AddStudent()
        {
            string name, dob, address;

            Console.Write("Enter student's name: ");
            name = Console.ReadLine();

            Console.Write("Enter student's dob: ");
            dob = Console.ReadLine();

            Console.Write("Enter student's address: ");
            address = Console.ReadLine();

            ClassManager.ShowAllClasses();
            Class c = null;
            string classId = "-1";
            while (c == null)
            {
                Console.Write("Enter student's class id (0 to skip): ");
                classId = Console.ReadLine();

                if (classId == "0")
                {
                    break;  
                }

                c = ClassManager.GetClassById(classId);

                if (c == null)
                {
                    Console.WriteLine("Class not found. Please try again.");
                }
            }


            Student s = new Student
            {
                Name = name,
                Dob = dob,
                Address = address,
                Class = c
            };

            StudentManager.AddStudent(s);
        }

        private static void ShowAllStudents()
        {
            if (StudentManager.Students.Count == 0)
            {
                Console.WriteLine("No student found");
            }
            else
            {
                StudentManager.ShowAllStudents();
            }
        }
    }
}
