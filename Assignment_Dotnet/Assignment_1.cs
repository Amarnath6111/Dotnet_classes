using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Equal();
            Program.PosOrNeg();
            Program.Operations();
            Console.ReadLine();

        }
        static void Equal()
        {
            Console.WriteLine("enter two numbers");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            if (x == y)
            {
                Console.WriteLine($"{x} is equal to {y}");
            }
            else
            {
                Console.WriteLine($"{x} is not equal to {y}");
            }

        }
        static void PosOrNeg()
        {
            Console.WriteLine($"enter a number");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a>=0)
            {
                Console.WriteLine($"{a} is Positive");

            }
            else
            {
                Console.WriteLine($"{a} is Negative");
            }
        }
        static void Operations()
        {
            Console.WriteLine("enter two numbers");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int sum = x + y;
            Console.WriteLine($"{x} + {y}= {sum}");
            int diff = x - y;
            Console.WriteLine($"{x} - {y}= {diff}");
            int mul = x * y;
            Console.WriteLine($"{x} * {y}= {mul}");
            int div = x / y;
            Console.WriteLine($"{x} / {y}= {div}");



        }
    }
}
