using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy3
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
    public interface UserInterface
    {
        void showFirstScreen();
        void showStudentScreen();
        void showAdminScreen();
        void showAllStudentScreen();
        void showStudentRegistrationScreen();
        void introduceNewCourseScreen();
        void showAllCoursesScreen();

    }
    public class MainClass : UserInterface
    {
        public AppEngine appEngine;
        public void Data_entry(AppEngine obj1)
        {
            Console.WriteLine("-----student Registration-----");
            obj1 = new AppEngine();
            this.appEngine = obj1;
            Console.Write("enter the no of students to be Registered: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //Console.WriteLine("enter the no of Courses to be enrolled");
            //int cn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter student Id and name");
            for (int i = 0; i < n; i++)
            {
                Console.Write("enter student Id: ");
                int id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.Write("enter student name: ");
                string name = Console.ReadLine();
                Console.WriteLine();
                Student stu = new Student(id, name);
                appEngine.register(stu);
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
                appEngine.introduce(cou);
            }
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("--------Enrollment Status-------");
                Student student = appEngine.listOfStudents()[j];
                Console.WriteLine($"enter the course number from below courses for student {student.Student_Name} ");
                //Console.WriteLine($"{j}: {Obj_engine.listOfCourses[j]}");
                showAllCoursesScreen();
                int course_no = Convert.ToInt32(Console.ReadLine());
                Course course = appEngine.listOfCourses()[course_no - 1];
                appEngine.enroll(student, course);

            }

        }
        public void showFirstScreen()
        {
            Console.WriteLine("-------Welcome to Student Management System SMS.v1.0--------");
            Console.WriteLine("Please tell us who you are:\n1. Student\n2. Admin");
            Console.WriteLine("Enter your choice (1 or 2): ");
            int op = Convert.ToInt32(Console.ReadLine());
            //AppEngine obj_Engine = new AppEngine();
            //this.appEngine = obj_Engine;
            switch(op)
            {
                case 1:
                    showStudentScreen();
                    break;
                case 2:
                    showAdminScreen();
                    break;
                default:
                    Console.WriteLine("invalid option, please select correct option ");
                    showFirstScreen();
                    break;

            }
        }

        public void showStudentScreen()
        {
            Console.WriteLine("------Student Screen:------ ");
            Console.WriteLine("1.View all courses for enrollment");
            Console.WriteLine("2.Register for a course");
            Console.WriteLine("3.Back to login window of Student Management System");
            Console.WriteLine("4.Exit");
            Console.Write("Enter any option from above: ");
            int n = Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1:
                    showAllCoursesScreen();
                    showStudentScreen();
                    break;
                case 2:
                    showStudentRegistrationScreen();
                    break;
                case 3:
                    showFirstScreen();
                    break;
                case 4:
                    Console.WriteLine("press any key to exit");
                    break;
                default:
                    Console.WriteLine("invalid option, please select correct option ");
                    showStudentScreen();
                    break;

            }
        }

        public void introduceNewCourseScreen()
        {
            Console.WriteLine("Introduction of new course");
            Console.WriteLine("enter course id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            foreach(var i in appEngine.listOfCourses())
            {
                if(i.Course_id==id)
                {
                    Console.WriteLine("This Course Id:{id} is already introduced to another course ,please enter valid course Id");
                    break;
                }
                else
                {
                    Console.WriteLine("enter the Course name");
                    string name = Console.ReadLine();
                    if (i.Course_name == name)
                    {
                        Console.WriteLine($"This Course Name:{name} is already introduced, please enter valid course name");
                        break;
                    }
                    else
                    {
                        Course course = new Course(id, name);
                        appEngine.introduce(course);
                    }
                    break;
                    //Course course = new Course(id, name);
                    //appEngine.introduce(course);

                }
            }
           
            showFirstScreen();

        }

        public  void showAdminScreen()
        {
            Console.WriteLine("------Admin Menu for enrollment:-------");
            Console.WriteLine("1. Introduction New Course");
            Console.WriteLine("2. View All the Students in Student Management System");
            Console.WriteLine("3. view all students and their enrolled courses");
            Console.WriteLine("4.Back to login window of Student Management System");
            Console.WriteLine("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    introduceNewCourseScreen();
                    break;
                case 2:
                    showAllStudentScreen();
                    break;
                case 3:
                    List<Enroll> enrollment = new List<Enroll>(appEngine.listOfEnrollments());
                    foreach (var en3 in enrollment)
                    {
                        Console.WriteLine($" student id: {en3.Student.Student_Id} student name: {en3.Student.Student_Name} and course id: {en3.Course.Course_id} Course name: {en3.Course.Course_name} ");
                    }
                    showFirstScreen();
                    break;

                case 4:
                    showFirstScreen();
                    break;
                default:
                    Console.WriteLine("invalid option, please select the correct option");
                    showAdminScreen();
                    break;

            }
        }

        public  void showAllCoursesScreen()
        {
            List<Course> coursesList =appEngine.listOfCourses().ToList();
            Console.WriteLine("Total List Of Courses are: ");
            int count = 1;
            foreach (var Course in coursesList)
            {
                Console.WriteLine($"SNo:{count}. courde Id: {Course.Course_id} and Course name: {Course.Course_name} ");
                count += 1;
            }
            //showStudentScreen();
        }

        public void showAllStudentScreen()
        {
            List<Student> studentList = new List<Student>(appEngine.listOfStudents());
            Console.WriteLine("list of total students in student management system are: ");
            int count = 1;
            foreach(var stu in studentList)
            {
                Console.WriteLine($"{count}. student id: {stu.Student_Id} student name: {stu.Student_Name} ");
                count += 1;
            }
            showFirstScreen();
        }
        public  void showStudentRegistrationScreen()
        {
            Console.Write("enter student id: ");
            int sid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //Console.Write("enter course id: ");
            //int cid= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            List<Student> student = new List<Student>(appEngine.listOfStudents());
            List<Course> courses = new List<Course>(appEngine.listOfCourses());
            List<Enroll> enrollment = new List<Enroll>(appEngine.listOfEnrollments());
            foreach (var en in enrollment)
            {
                if (en.Student.Student_Id == sid ) 
                {
                    Console.WriteLine("This student is already registered for following courses");
                    appEngine.enroll(en.Student, en.Course);
                    Console.WriteLine("Do you want to enroll in another course, If yes press 1 else press 0");
                    int op1 = Convert.ToInt32(Console.ReadLine());
                    switch (op1)
                    {
                        case 1:
                            Console.WriteLine("enter Course Id from below:");
                            showAllCoursesScreen();
                            int cid2= Convert.ToInt32(Console.ReadLine());
                            foreach (var en1 in courses)
                            { 
                                if (en1.Course_id == cid2)
                                {
                                    string cname = en1.Course_name;
                                    Course c2 = new Course(cid2, cname);
                                    Student st2 = en.Student;
                                    appEngine.enroll(st2, c2);
                                }
                            }
                            break;
                        default:
                            Console.WriteLine("hello");
                            showStudentScreen();
                            break;
                    }
                    break;
                }
                else
                {
                    Console.WriteLine($"The student id: {sid} you have entered is not present");
                    Console.WriteLine("If you would like to enroll please enter 1 else enter 0");
                    int option3= Convert.ToInt32(Console.ReadLine());
                    switch(option3)
                    {
                        case 1:
                            //List<Course> courses = new List<Course>(appEngine.listOfCourses());
                            Console.WriteLine("for enrolling please enter name");
                            string sname = Console.ReadLine();
                            Student student1 = new Student(sid, sname);
                            appEngine.register(student1);
                            Console.WriteLine("enter course id");
                            showAllCoursesScreen();
                            int cid = Convert.ToInt32(Console.ReadLine());
                            Course course1;
                            foreach (var corid in courses)
                            {
                                if (corid.Course_id == cid)
                                {
                                    course1 = new Course(cid, corid.Course_name);
                                    appEngine.enroll(student1, course1);
                                    break;
                                }
                                //else
                                //{
                                //    Console.WriteLine("enter a valid course id ");
                                //    break;
                                //}

                            }
                            break;
                        default:
                            break;

                    }
                    //Console.WriteLine("for enrolling please enter name");
                    //string sname = Console.ReadLine();
                    //Student student1 = new Student(sid, sname);
                    //appEngine.register(student1);
                    //Console.WriteLine("enter course id");
                    //int cid = Convert.ToInt32(Console.ReadLine());
                    //Course course1;
                    //foreach (var corid in courses)
                    //{
                    //    if (corid.Course_id == cid)
                    //    {
                    //        course1 = new Course(cid, corid.Course_name);
                    //        appEngine.enroll(student1, course1);
                    //    }
                    //    else
                    //    {
                    //        Console.WriteLine("enter a valid course id ");
                    //        break;
                    //    }

                    //}
                    break;
                    
                }
            }
           
            showStudentScreen();

        }
    }
    public class App
    {
       public static void Main()
        {
            AppEngine obj=new AppEngine();
            //App_extend.Data_entry();
            MainClass main = new MainClass();
            main.Data_entry(obj);
            main.showFirstScreen();
            Console.ReadLine(  );
        }
    }

}
