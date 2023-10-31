using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToSqlAssignmentEf.Model;

namespace LinqToSqlAssignmentEf
{
    class Program
    {
        static EmployeeContext empdb = new EmployeeContext();
        static DateTime young1;
        public static void updateEmployee()
        {
            var EmployeeEf = new EmployeeEf
            {
                Empid = 1001,
                FirstName = "Malcolm",
                LastNmae = "Daruwalla",
                Title = "Manager",
                DOB = DateTime.Parse("1984-11-16"),
                DOJ = DateTime.Parse("2011-6-8"),
                City = "Mumbai"
            };
            empdb.EmployeeEfs.Add(EmployeeEf);
            empdb.SaveChanges();
            EmployeeEf = new EmployeeEf
            {
                Empid = 1002,
                FirstName = "Asdin",
                LastNmae = "Dhalla",
                Title = "AsstManager",
                DOB = DateTime.Parse("1984-08-20 "),
                DOJ = DateTime.Parse("2012-7-7"),
                City = "Mumbai"
            };
            empdb.EmployeeEfs.Add(EmployeeEf);
            empdb.SaveChanges();
            EmployeeEf = new EmployeeEf
            {
                Empid = 1003,
                FirstName = "Madhavi",
                LastNmae = "Oza",
                Title = "Consultant",
                DOB = DateTime.Parse("1978-11-14 "),
                DOJ = DateTime.Parse("2015-4-12"),
                City = "Pune"
            };
            empdb.EmployeeEfs.Add(EmployeeEf);
            empdb.SaveChanges();
            EmployeeEf = new EmployeeEf
            {
                Empid = 1004,
                FirstName = "Saba",
                LastNmae = "Shaikh",
                Title = "SE",
                DOB = DateTime.Parse("1990-6-3"),
                DOJ = DateTime.Parse("2016-2-2"),
                City = "Pune"
            };
            empdb.EmployeeEfs.Add(EmployeeEf);
            empdb.SaveChanges();
            EmployeeEf = new EmployeeEf
            {
                Empid = 1005,
                FirstName = "Nazia ",
                LastNmae = "Shaikh",
                Title = "SE",
                DOB = DateTime.Parse("1991-3-8 "),
                DOJ = DateTime.Parse("2016-2-2"),
                City = "Mumbai"
            };
            empdb.EmployeeEfs.Add(EmployeeEf);
            empdb.SaveChanges();
            EmployeeEf = new EmployeeEf
            {
                Empid = 1006,
                FirstName = "Amit",
                LastNmae = "Pathak",
                Title = "Consultant",
                DOB = DateTime.Parse("1989-11-7"),
                DOJ = DateTime.Parse("2014-8-8"),
                City = "Chennai"
            };
            empdb.EmployeeEfs.Add(EmployeeEf);
            empdb.SaveChanges();
            EmployeeEf = new EmployeeEf
            {
                Empid = 1007,
                FirstName = "Vijay",
                LastNmae = "Natrajan",
                Title = "Consultant",
                DOB = DateTime.Parse("1989-12-2"),
                DOJ = DateTime.Parse("2015-6-1"),
                City = "Mumbai"
            };
            empdb.EmployeeEfs.Add(EmployeeEf);
            empdb.SaveChanges();
            EmployeeEf = new EmployeeEf
            {
                Empid = 1008,
                FirstName = "Rahul",
                LastNmae = "Dubey ",
                Title = "Associate",
                DOB = DateTime.Parse("1993-11-11"),
                DOJ = DateTime.Parse("2014-11-6"),
                City = "Chennai"
            };
            empdb.EmployeeEfs.Add(EmployeeEf);
            empdb.SaveChanges();
            EmployeeEf = new EmployeeEf
            {
                Empid = 1009,
                FirstName = "Suresh ",
                LastNmae = "Mistry",
                Title = " Associate",
                DOB = DateTime.Parse("1992-8-12"),
                DOJ = DateTime.Parse("2014-12-3"),
                City = "Chennai"
            };
            empdb.EmployeeEfs.Add(EmployeeEf);
            empdb.SaveChanges();
            EmployeeEf = new EmployeeEf
            {
                Empid = 1010,
                FirstName = "Sumit",
                LastNmae = "Shah",
                Title = "Manager",
                DOB = DateTime.Parse("1992-8-12"),
                DOJ = DateTime.Parse("2016-1-2"),
                City = "Pune"
            };
            empdb.EmployeeEfs.Add(EmployeeEf);
            empdb.SaveChanges();


        }
        public static void Display()
        {
            var list1 = empdb.EmployeeEfs.ToList();
            var emp1 = from emp in empdb.EmployeeEfs
                       select emp;
            var emp2 = list1.FindAll(x => x.DOJ < DateTime.Parse("2015-01-01"));
            
            Console.WriteLine("employees who joined before 1-1-2015 are: ");
            foreach(var i in emp2)
            {
                Console.WriteLine(i.Empid+"  "+i.FirstName+"  "+i.DOJ+"  "+i.City);
            }
            Console.WriteLine("------------------------------------------------");

            var emp3 = list1.FindAll(x => x.DOB== DateTime.Parse("1990-01-01"));
            if (emp3 == null)
            {
                Console.WriteLine("employees whos Date of Birth is on 1990-01-01 are: " );
                foreach (var i in emp3)
                {
                    Console.WriteLine(i.Empid + "  " + i.FirstName + "  " + i.DOJ + "  " + i.City);
                }
            }
            else
            {
                Console.WriteLine("There is no employee whos Date of Birth is on 1990-01-01   ");
            }
            Console.WriteLine("------------------------------------------------");
            var emp4 = list1.FindAll(x => x.Title=="Consultant" | x.Title=="Associate");

            Console.WriteLine("employees whos Title is Consultant or Associate ");
            foreach (var i in emp4)
            {
                Console.WriteLine(i.Empid + "  " + i.FirstName + "  " + i.DOJ + "  " + i.City+"  "+i.Title);
            }
            Console.WriteLine("------------------------------------------------");
            var emp5 = list1.Count();
            Console.WriteLine("Total no of Employees are:  "+emp5);
            var emp6 = list1.Count(x => x.City == "Chennai");
            Console.WriteLine("Total no of Employees belonging to Chennai are:  "+emp6);
            var emp7 = list1.FindAll(x => x.DOJ > DateTime.Parse("2015-01-01"));
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("employees who joined after 1-1-2015 are: ");
            foreach (var i in emp7)
            {
                Console.WriteLine(i.Empid + "  " + i.FirstName + "  " + i.DOJ + "  " + i.City);
            }
            Console.WriteLine("------------------------------------------------");
            var emp8 = list1.FindAll(x => x.Title != "Associate");

            Console.WriteLine("employees whos Designation  is not Associate ");
            foreach (var i in emp8)
            {
                Console.WriteLine(i.Empid + "  " + i.FirstName + "  " + i.DOJ + "  " + i.City + "  " + i.Title);
            }
            Console.WriteLine("------------------------------------------------");
            var emp9 = from emp in empdb.EmployeeEfs
                       orderby emp.City
                       select emp ;
            foreach (var i in emp9)
            {
                Console.WriteLine(i.FirstName+"  "+i.DOB+"  "+i.DOJ+"  "+i.Title+"  "+i.City);
            }
            Console.WriteLine("------------------------------------------------");
            //var min1 = empdb.EmployeeEfs.Min();
            var emp10 = from emp in empdb.EmployeeEfs
                        orderby emp.DOB descending
                        select emp;
            var listemp = emp10.ToList();
            
            for (var i = 0; i< emp5;i++)
            {
                var young = listemp[0];
                 young1 = young.DOB;
            }
            foreach(var i in emp10)
            {
                if(i.DOB==young1)
                {
                    Console.WriteLine("the youngest employee is: \n  "+i.FirstName + "  "+ i.DOB + "  " + i.City + "  " + i.Title);
                }
            }

        }
        static void Main(string[] args)
        {
            //updateEmployee();
            Display();
            Console.ReadLine();
        }
    }
}
