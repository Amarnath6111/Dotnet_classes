using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_dotnet_5
{
    class Customer
    {
        string  Name, City, Phone;
        int Age, CustomerId;
        public Customer()
        {

        }
        public  Customer(string name, string city, int age, int customerid, string phone)
        {
            Name = name;
            City = city;
            Age = age;
            CustomerId = customerid;
            Phone = phone;
        }
        public static void DisplayCustomer()
        {
            Console.WriteLine("enter the details of the customer");
            Console.Write("enter customer name ");
            string n = Console.ReadLine();
            Console.Write("enter customer location ");
            string ci = Console.ReadLine();
            Console.Write("enter customer age ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter customer Id ");
            int cu = Convert.ToInt32(Console.ReadLine());
            Console.Write("enter customer Phone number ");
            string p = Console.ReadLine();
            Customer customer = new Customer(n, ci, a, cu, p);
            Console.WriteLine($" custumer name: {customer.Name}, custumer location: {customer.City}, custumer age: {customer.Age}, custumer id: {customer.CustomerId}, custumer phone number: {customer.Phone}");
        }
        ~Customer()
        {
            Console.WriteLine("Destructed");
        }
    }
}
