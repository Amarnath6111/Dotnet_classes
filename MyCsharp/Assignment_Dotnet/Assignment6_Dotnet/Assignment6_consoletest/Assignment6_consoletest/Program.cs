using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Final_Library;


namespace Assignment6_consoletest
{
    class Program
    {
        static public void Main(string[] args)
        {
            Class1 obj = new Class1();
            Console.WriteLine("enter the details of the passenger");
            Console.Write("enter the Name of the passenger: ");
            obj.Name = Console.ReadLine();
            Console.Write("enter the age of the passenger");
            obj.Age = Convert.ToInt32(Console.ReadLine());
            obj.CalculateConcession(obj.Age);
            Console.ReadLine();
        }
    }
}
