using CaseStudy_1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseStudy_1
{
    public class Student
    {
        public int Student_Id { get; set; }
        public string Student_Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public  Student(int id,string name, DateTime dateofbirth)
        {
            Student_Id = id;
            Student_Name = name;
            DateOfBirth = dateofbirth;
        }

        public Student()
        {
        }
    }
    public class Info
    {
         string name;
         int id;
         DateTime date;
        public void Display(Student student)
        {
            Console.WriteLine("enter the details of the student");
            Console.Write("enter student name: ");
            this.name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("enter student Date of Birth: ");
            if (DateTime.TryParse(Console.ReadLine(), out this.date))
            {
                // Console.WriteLine("Your date of birth is: " + date.ToString("yyyy-MM-dd"));
            }
            else
            {
                Console.WriteLine("Invalid date format. Please enter in yyyy-MM-dd format.");
            }
            Console.WriteLine();
            Console.Write("enter student Id: ");
            this.id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            List<Student> Liststu1 = new List<Student>();
            Student student1 = new Student(id, name,date);
            Liststu1.Add(student1);
            foreach (var i in Liststu1 )
            {
                Console.WriteLine($"Student name: {i.Student_Name} \n Student Id: {i.Student_Id} \n Date of birth: {i.DateOfBirth}");
            }
        }

    }
    public class App
    {
        static int n;
        public static void Scenario1()
        {
            Console.Write("enter the no of student objects to be created");
            n = Convert.ToInt32(Console.ReadLine());
            CaseStudy_1.Student[] student_arr = new CaseStudy_1.Student[n];
           
        }
        public static void Scenario2()
        {
            CaseStudy_1.Student[] student_arr = new CaseStudy_1.Student[n];
            for (int i = 0; i < n; i++)
            {
                Info info = new Info();
                info.Display(student_arr[i]);
            }
            
        }
        static void Main(string[] args)
        {
            Scenario1();
            Scenario2();
            Console.ReadLine();
        }
    }
}

