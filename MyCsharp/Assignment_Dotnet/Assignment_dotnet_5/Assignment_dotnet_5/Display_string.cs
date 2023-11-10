using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_dotnet_5
{
    class Display_string
    {
        public static void Display()
        {
            //Accept();
            string Fname = Console.ReadLine();
            string Lname = Console.ReadLine();
            Console.WriteLine($"{Fname.ToUpper()}");
            Console.WriteLine($"{Lname.ToUpper()}");

        }
        static void Main(string[] args)
        {
            //Program.Display();
            //Occurrence.Letter();
            // DateTime d = 2-3-23;
            //DateTime d = new DateTime();
            //SalesDetails sales_obj = new SalesDetails(12, 34, 634, 4500, d);
            //SalesDetails.ShowDetails();
            Customer.DisplayCustomer();
            Console.ReadLine();


        }
    }
}
    

