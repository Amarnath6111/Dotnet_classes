using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_net3
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int subtract = 0;
            int multiply = 0;
            int divide = 0;

            Program.Out_fun(20, 10, out total, out subtract, out multiply, out divide);
            Console.WriteLine($"total is {total}, diff is {subtract},mul is {multiply}, divi is {divide}");
            Console.ReadLine();

        }
        public static void Out_fun(int a,int b,out int add,out int sub, out int mul,out int div)
        {
            add = a + b;
            sub = a - b;
            mul = a * b;
            div = a / b;


        }
    }
}
