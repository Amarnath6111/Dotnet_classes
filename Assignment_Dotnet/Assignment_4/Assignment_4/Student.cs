using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_4
{
    class Student
    {
        int Rollno, Sem;
        string Name, Class, Branch;
        static int [] Marks= new int [5];
        public Student(int rollno,string name,string classs ,int sem,string branch)
        {
            Rollno = rollno;
            Sem = sem;
            Name = name;
            Class = classs;
            Branch = branch;
            Console.WriteLine($"Rollno: {Rollno}, Sem: {Sem}, Name: {Name}, Class: {Class}, Branch {Branch} ");
        }
        public static void GetMarks()
        {
            Console.WriteLine("Enter the marks");
            for(int i=0;i<Marks.Length;i++)
            {
               // Marks[i]= Convert.ToInt32(Console.ReadLine());
                Console.Write($"enter subject {i+1} marks: ");
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        public static void DisplayResult()
        {
            double avg = 0;
            double sum = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                sum += Marks[i];
            }
            avg = sum / Marks.Length;
            Console.WriteLine($"The average of all the subjects are {avg}");
            bool flag = true;
            for (int i = 0; i < Marks.Length; i++)
            {
                if (Marks[i] < 35)
                {
                    flag = false;

                }
            }
            if (flag == false)
            {
                Console.WriteLine("Failed");
            }
            else if (avg < 50 )
            {
                Console.WriteLine("Failed");
            }
            else
            {
                Console.WriteLine("Passed");
            }

        }
        public static void DisplayData()
        {
            Student obj = new Student(102, "Amarnath", "B1", 6, "CSE");
            GetMarks();
            DisplayResult();
        }
        static void Main(string[] args)
        {
            Student.DisplayData();
            Accounts.ShowData();
            Console.ReadLine();
        }
     
    }
}
