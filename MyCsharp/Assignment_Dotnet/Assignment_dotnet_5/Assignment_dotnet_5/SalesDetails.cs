using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_dotnet_5
{
    class SalesDetails
    {
        static int Salesno, Productno, Qty;
        static double Price;
        static double Totalamount = 0;
        static DateTime Dateofsale;
        public SalesDetails(int salesno, int productno, int qty, double price, DateTime dateofsale)
        {
            Salesno = salesno;
            Productno = productno;
            Qty = qty;
            Price = price;
            Dateofsale = dateofsale;
        }
        public static void Sales(int qty, double price)
        {
            Qty = qty;
            Price = price;
            Totalamount = Qty * Price;
        }
        public static void ShowDetails()
        {
            Console.WriteLine("enter the sales number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the product  number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the quantity");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the Price of the product");
            double pricee = Convert.ToDouble(Console.ReadLine());
            DateTime date = new DateTime();
            Sales(c,pricee);
            SalesDetails sales_obj = new SalesDetails(a, b, c, pricee, date);
            Console.WriteLine($" salesno: {Salesno} productno:{Productno} quantity:{Qty} Price of the product:{Price} Dateofsale:{Dateofsale} ");
            Console.WriteLine("the total amount for the product is: {0}"+Totalamount);


        }
    }
}

