using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CodeBasedTest2
{
    public abstract class Student
    {
        static string Name; public static int grade; static int ID;
        public Student(string Name, int grade, int ID)
        {
            grade = grade;
            ID = ID;
            Name = Name;
        }
        public abstract bool isPassed(int grade);
    }



    public class Under_grad : Student
    {
        public Under_grad(string Name, int grade, int ID) : base(Name, grade, ID)
        {



        }
        public override bool isPassed(int grade)
        {



            return grade >= 70;
        }



    }
    public class Grad : Student
    {
        public Grad(string Name, int grade, int ID) : base(Name, grade, ID)
        {



        }
        public override bool isPassed(int grade)
        {



            return grade >= 80;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            string n = Console.ReadLine();
            Console.WriteLine("Enter Grade ");
            int g = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter ID");
            int sID = Convert.ToInt32(Console.ReadLine());
            Student underGr = new Under_grad(n, g, sID);
            Console.WriteLine($"Student name: {n}, Student grade: {g}, Student idd: {sID}");
            Console.WriteLine($"Status: {underGr.isPassed(Under_grad.grade)}");
            Console.Read();
        }
    }
}