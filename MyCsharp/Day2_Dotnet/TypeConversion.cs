using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCoding1
{
    class TypeConversion
    {
        static void Main()
        {
            Console.WriteLine("enter employee name");
            string name= Console.ReadLine();
            Console.WriteLine("Enter employee ID");
            int id = Convert.ToInt32(Console.ReadLine());
            string a= "123";
            int b;
            b = int.Parse(a);
            Console.WriteLine(b);
            TypeConversion.Example();
            Console.ReadLine();
            
        }
        public static void Example()
        {
            double cgp;
            Console.WriteLine("enter your btech cgp");
            string i = Console.ReadLine();
            bool val = double.TryParse(i, out cgp );
            if (val) 
            {
                Console.WriteLine(cgp);
            }
            else
            {
                Console.WriteLine("error");

            }


        }
    }
}
