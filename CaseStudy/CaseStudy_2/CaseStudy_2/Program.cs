using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CaseStudy_2
{
    public class Student
    {
        public int Student_Id { get; set; }
        public string Student_Name { get; set; }
        public Student(int id, string name)
        {
            Student_Id = id;
            Student_Name = name;
        }
    }
    public class Course
    {
        public int Course_id { get; set; }
        public string Course_name { get; set; }
        public Course(int Cid, string cname)
        {
            Course_id = Cid;
            Course_name = cname;
        }
    }
    public class Enroll
    {
        public Student Student { get; set; }
        public Course Course { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public Enroll(Student student, Course course, DateTime date)
        {
            Student = student;
            Course = course;
            EnrollmentDate = date;

        }

    }
    public class AppEngine
    {
        private List<Student> student_arr = new List<Student>();

        private List<Course> course_arr = new List<Course>();

        private List<Enroll> enrollment_arr = new List<Enroll>();
        public void introduce(Course ccourse)
        { 
            course_arr.Add(ccourse);
            Console.WriteLine($"Course {ccourse.Course_name} has been introduced.");
        }
        public void register(Student sstudent)
        {
            student_arr.Add(sstudent);
            Console.WriteLine($"Student {sstudent.Student_Name} has been registered.");
        }
        public Student[] listOfStudents()
        { 
            return student_arr.ToArray();
        }
        public Course[] listOfCourses()
        {
            return course_arr.ToArray();
        }
        public void enroll(Student student, Course course)
        {
            Enroll enrollment = new Enroll(student, course, DateTime.Now);
            enrollment_arr.Add(enrollment);
            Console.WriteLine($"{student.Student_Name} has been enrolled in {course.Course_name} on {enrollment.EnrollmentDate}.");
        }
        public Enroll[] listOfEnrollments()

        {
            return enrollment_arr.ToArray();
        }

    }
    public class App
    {
        public static void Main()
        {
            AppEngine Obj_engine = new AppEngine();
            Console.Write("enter the no of students to be Registered: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //Console.WriteLine("enter the no of Courses to be enrolled");
            //int cn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter student Id and name");
            for (int i=0;i<n;i++)
            {
                Console.Write("enter student Id: ");
                int id= Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("enter student name: ");
                string name = Console.ReadLine();
                Console.WriteLine();
                Student stu= new Student(id, name);
                Obj_engine.register(stu);
            }
            Console.Write("enter the no of Courses to be enrolled: ");
            int cn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("enter Course Id and name");
            for (int j = 0; j < cn; j++)
            {
                Console.Write("enter course Id: ");
                int cid = Convert.ToInt32(Console.ReadLine());
                Console.Write("enter course name: ");
                string cname = Console.ReadLine();
                Console.WriteLine();
                Course cou = new Course(cid, cname);
                Obj_engine.introduce(cou);
            }
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("--------Enrollment Status-------");
                Student student = Obj_engine.listOfStudents()[j];
                Console.WriteLine($"enter the course number from 1 to {cn} for student {student.Student_Name} ");
                //Console.WriteLine($"{j}: {Obj_engine.listOfCourses[j]}");
                int course_no = Convert.ToInt32(Console.ReadLine());
                Course course = Obj_engine.listOfCourses()[course_no - 1];
                Obj_engine.enroll(student, course);

            }
            Console.ReadLine();
        }

    }
}
