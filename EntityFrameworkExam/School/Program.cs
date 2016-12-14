using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Metoder metoder = new Metoder();
                Console.WriteLine("Choose \n1] Add Student \n2] Add Course");
                int input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("Firstname: ");
                        string fname = Console.ReadLine();
                        Console.WriteLine("Lastname: ");
                        string lname = Console.ReadLine();
                        Console.WriteLine("CourseID: ");
                        int courseID = int.Parse(Console.ReadLine());

                        metoder.AddStudent(fname, lname, courseID);
                        break;
                    case 2:
                        Console.WriteLine("Course Name: ");
                        string cName = Console.ReadLine(); 

                        metoder.AddCourse(cName);
                        break;
                    case 3:
                        Console.WriteLine("Delete student by it's Student ID: ");
                        int sID = int.Parse(Console.ReadLine());

                        metoder.DeleteStudent(sID);
                        break;
                }
            }
        }

        
    }

    class Metoder
    {
        public void AddStudent(string fname, string lname, int courseID)
        {
            using (var ctx = new SchoolEntities())
            {
                Student newStundet = new Student()
                {
                    firstName = fname,
                    lastName = lname,
                    courseID = courseID
                };
                ctx.Student.Add(newStundet);
                ctx.SaveChanges();
            }
        }

        public void DeleteStudent(int studentID)
        {
            using (var ctx = new SchoolEntities())
            {
                var deleteStudent = ctx.Student.Where(x => x.studentID == studentID).First(); 
                ctx.Student.Remove(deleteStudent);
                ctx.SaveChanges();
                Console.WriteLine("You've deleted Student ID: {0}", studentID);
            }
        }

        public void AddCourse(string courseName)
        {
            using (var ctx = new SchoolEntities())
            {
                Course newCourse = new Course()
                {
                    courseName = courseName
                };
                ctx.Course.Add(newCourse);
                ctx.SaveChanges();
            }
        }
    }
}

