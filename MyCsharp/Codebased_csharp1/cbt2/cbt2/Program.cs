using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CodeBasedTest2
{
    public class Products
    {
        public string name; public int pid; public int price;
        public Products(string n, int pID, int p)
        {
            name = n;
            pid = pID;
            price = p;
        }
        static void Main(string[] args)
        {
            List<Products> products = new List<Products>();
            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Enter product id");
                int pid = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter name");
                string name = Console.ReadLine();
                Console.Write("Product price");
                int price = Convert.ToInt32(Console.ReadLine());



                Products pr = new Products(name, pid, price);
                products.Add(pr);
            }
            List<Products> ord= products.OrderBy(p => p.price).ToList();




            foreach (var i in ord)
            {
                Console.WriteLine($"id: {i.pid}    \n" +
                    $"name: {i.name}    \n" +
                    $"price: {i.price}");
            }
            Console.Read();
        }
    }



}