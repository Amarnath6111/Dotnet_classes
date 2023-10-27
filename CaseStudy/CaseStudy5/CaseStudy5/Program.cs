using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CaseStudy5
{
    
    
        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public DateTime DateOfBirth { get; set; }
            public Student(int id, string name, DateTime dateOfBirth)
            {
                ID = id;
                Name = name;
                DateOfBirth = dateOfBirth;
            }
        }

        public class Course
        {
            public int ID { get; set; }
            public string Name { get; set; }

            public Course(int id, string name)
            {
                ID = id;
                Name = name;
            }
        }

        public class Enroll
        {
            public Student Student { get; set; }
            public Course Course { get; set; }
            public DateTime EnrollmentDate { get; set; }

            public Enroll(Student student, Course course, DateTime enrollmentDate)
            {
                Student = student;
                Course = course;
                EnrollmentDate = enrollmentDate;
            }
        }

        public class AppEngine
        {
            private string connectionString = "The connection string here";
            public static SqlConnection con;
            public static SqlCommand cmd;
            public static SqlDataReader dr;
            //private string connectionString = "The connection string here";
            private List<Student> student_arr = new List<Student>();

            private List<Course> course_arr = new List<Course>();

            private List<Enroll> enrollment_arr = new List<Enroll>();
            public void Introduce(Course course)
            {
                con = GetConnection();
                try
                {
                  
                    cmd = new SqlCommand("insert into Course values(@id,@name)", con);
                    cmd.Parameters.AddWithValue("@id", course.ID);
                    cmd.Parameters.AddWithValue("@name", course.Name);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                        Console.WriteLine("Record Inserted");
                    else
                        Console.WriteLine("Not Inserted..");
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }
            static SqlConnection GetConnection()
            {
                //when windows authenticated
                con = new SqlConnection("Data Source=ICS_LAP_7347;Initial Catalog=infiniteDB;Integrated Security=True");
                con.Open();
                return con;
            }

            public void Register(Student student)
            {
                con = GetConnection();
                try
                {

                    cmd = new SqlCommand("insert into Course values(@id,@name)", con);
                    cmd.Parameters.AddWithValue("@id", student.ID);
                    cmd.Parameters.AddWithValue("@name", student.Name);
                    cmd.Parameters.AddWithValue("@Dob", student.DateOfBirth);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                        Console.WriteLine("Record Inserted");
                    else
                        Console.WriteLine("Not Inserted..");
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }

            public List<Student> ListOfStudents()
            {

                con = GetConnection();
                cmd = new SqlCommand("select * from Student", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // course_arr.Add(
                    Student st = new Student(dr.GetInt32(0), dr.GetString(1), dr.GetDateTime(2));
                    student_arr.Add(st);

                }
                return student_arr;
            }
            public List<Course> ListOfCourses()
            {

                con = GetConnection();
                cmd = new SqlCommand("select * from Course", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    // course_arr.Add(
                    Course cr = new Course(dr.GetInt32(0), dr.GetString(1));
                    course_arr.Add(cr);
                }
                return course_arr;

            }
            public void Enroll(Student student, Course course)
            {
                con = GetConnection();
                try
                {

                    cmd = new SqlCommand("insert into Course values(@sid,@sname,@cid,@cname,@date)", con);
                    cmd.Parameters.AddWithValue("@sid", student.ID);
                    cmd.Parameters.AddWithValue("@sname", student.Name);
                    //cmd.Parameters.AddWithValue("@sDob", student.DateOfBirth);
                    cmd.Parameters.AddWithValue("@cid", course.ID);
                    cmd.Parameters.AddWithValue("@cname", course.Name);
                    DateTime dat = DateTime.Now;
                    cmd.Parameters.AddWithValue("@date", dat);
                    int res = cmd.ExecuteNonQuery();
                    if (res > 0)
                        Console.WriteLine("Record Inserted");
                    else
                        Console.WriteLine("Not Inserted..");
                }
                catch (SqlException se)
                {
                    Console.WriteLine(se.Message);
                }
            }
            public List<Enroll> ListOfEnrollments()
            {
                List<Enroll> enrollments = new List<Enroll>();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Enrollments", connection))
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int studentID = reader.GetInt32(1);
                            int courseID = reader.GetInt32(2);
                            DateTime enrollmentDate = reader.GetDateTime(3);
                            Student student = ListOfStudents().Find(s => s.ID == studentID);
                            Course course = ListOfCourses().Find(c => c.ID == courseID);
                            enrollments.Add(new Enroll(student, course, enrollmentDate));
                        }
                    }
                }
                return enrollments;
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
            DateTime date;
            public void Data_entry(AppEngine obj1)
            {
                //DateTime date;
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
                    Console.WriteLine("enter Dob");
                    //DateTime date;
                    if (DateTime.TryParse(Console.ReadLine(), out this.date))
                    {
                        // Console.WriteLine("Your date of birth is: " + date.ToString("yyyy-MM-dd"));
                    }
                    else
                    {
                        Console.WriteLine("Invalid date format. Please enter in yyyy-MM-dd format.");
                    }
                    Console.WriteLine();

                    Student stu = new Student(id, name, date);
                    //appEngine.register(stu);
                    appEngine.Register(stu);
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
                    appEngine.Introduce(cou);
                }
                for (int j = 0; j < n; j++)
                {
                    Console.WriteLine("--------Enrollment Status-------");
                    Student student = appEngine.ListOfStudents()[j];
                    Console.WriteLine($"enter the course number from below courses for student {student.Name} ");
                    //Console.WriteLine($"{j}: {Obj_engine.listOfCourses[j]}");
                    showAllCoursesScreen();
                    int course_no = Convert.ToInt32(Console.ReadLine());
                    Course course = appEngine.ListOfCourses()[course_no - 1];
                    //appEngine.Enroll(student, course);

                }

            }
            public void showFirstScreen()
            {
                Console.WriteLine("-------Welcome to Student Management System SMS.v1.0--------");
                Console.WriteLine("Please tell us who you are:\n1. Student\n2. Admin");
                Console.WriteLine("Enter your choice (1 or 2): ");
                int op = Convert.ToInt32(Console.ReadLine());
                switch (op)
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
                switch (n)
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
                foreach (var i in appEngine.ListOfCourses())
                {
                    if (i.ID == id)
                    {
                        Console.WriteLine("This Course Id:{id} is already introduced to another course ,please enter valid course Id");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("enter the Course name");
                        string name = Console.ReadLine();
                        if (i.Name == name)
                        {
                            Console.WriteLine($"This Course Name:{name} is already introduced, please enter valid course name");
                            break;
                        }
                        else
                        {
                            Course course = new Course(id, name);
                            appEngine.Introduce(course);
                        }
                        break;
                    }
                }
                showFirstScreen();
            }

            public void showAdminScreen()
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
                        List<Enroll> enrollment = new List<Enroll>(appEngine.ListOfEnrollments());
                        foreach (var en3 in enrollment)
                        {
                            Console.WriteLine($" student id: {en3.Student.ID} student name: {en3.Student.Name} and course id: {en3.Course.ID} Course name: {en3.Course.Name} ");
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

            public void showAllCoursesScreen()
            {
                List<Course> coursesList = appEngine.ListOfCourses().ToList();
                Console.WriteLine("Total List Of Courses are: ");
                int count = 1;
                foreach (var Course in coursesList)
                {
                    Console.WriteLine($"SNo:{count}. courde Id: {Course.ID} and Course name: {Course.Name} ");
                    count += 1;
                }
                //showStudentScreen();
            }

            public void showAllStudentScreen()
            {
                List<Student> studentList = new List<Student>(appEngine.ListOfStudents());
                Console.WriteLine("list of total students in student management system are: ");
                int count = 1;
                foreach (var stu in studentList)
                {
                    Console.WriteLine($"{count}. student id: {stu.ID} student name: {stu.Name} ");
                    count += 1;
                }
                showFirstScreen();
            }
            public void showStudentRegistrationScreen()
            {
                Console.Write("enter student id: ");
                int sid = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
                List<Student> student = new List<Student>(appEngine.ListOfStudents());
                List<Course> courses = new List<Course>(appEngine.ListOfCourses());
                List<Enroll> enrollment = new List<Enroll>(appEngine.ListOfEnrollments());
                foreach (var en in enrollment)
                {
                    if (en.Student.ID == sid)
                    {
                        Console.WriteLine("This student is already registered for following courses");
                        appEngine.Enroll(en.Student, en.Course);
                        Console.WriteLine("Do you want to enroll in another course, If yes press 1 else press 0");
                        int op1 = Convert.ToInt32(Console.ReadLine());
                        switch (op1)
                        {
                            case 1:
                                Console.WriteLine("enter Course Id from below:");
                                showAllCoursesScreen();
                                int cid2 = Convert.ToInt32(Console.ReadLine());
                                foreach (var en1 in courses)
                                {
                                    if (en1.ID == cid2)
                                    {
                                        string cname = en1.Name;
                                        Course c2 = new Course(cid2, cname);
                                        Student st2 = en.Student;
                                        appEngine.Enroll(st2, c2);
                                    }
                                }
                                break;
                            default:
                                showStudentScreen();
                                break;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"The student id: {sid} you have entered is not present");
                        Console.WriteLine("If you would like to enroll please enter 1 else enter 0");
                        int option3 = Convert.ToInt32(Console.ReadLine());
                        switch (option3)
                        {
                            case 1:
                                //List<Course> courses = new List<Course>(appEngine.listOfCourses());
                                Console.WriteLine("for enrolling please enter name");
                                string sname = Console.ReadLine();
                                Student student1 = new Student(sid, sname, date);
                                appEngine.Register(student1);
                                Console.WriteLine("enter course id");
                                showAllCoursesScreen();
                                int cid = Convert.ToInt32(Console.ReadLine());
                                Course course1;
                                foreach (var corid in courses)
                                {
                                    if (corid.ID == cid)
                                    {
                                        course1 = new Course(cid, corid.Name);
                                        appEngine.Enroll(student1, course1);
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
                AppEngine obj = new AppEngine();
                MainClass main = new MainClass();
                main.Data_entry(obj);
                main.showFirstScreen();
                Console.ReadLine();
            }
        }
    
}
