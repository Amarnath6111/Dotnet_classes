using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codebased_csharp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Remove_char();
            Multiplication_table();
            Console.ReadLine();
        }
        static void Remove_char()
        {
            Console.WriteLine("enter the string");
            string str1 = Console.ReadLine();
            Console.WriteLine("enter the position to remove a character");
            int n = Convert.ToInt32(Console.ReadLine());
            string str2 = " ";
            for(int i=0;i<str1.Length;i++)
            {
                if (i == n)
                {
                    continue;
                }
                else
                {
                    str2+= str1[i];
                }
            }
            Console.WriteLine($"the string after removing the character of position{n} is {str2}");
            
        }
        static void Multiplication_table()
        {
            int multi = 0;
            Console.WriteLine("enter the number to get its multiplication table");
            int m = Convert.ToInt32(Console.ReadLine());
            for (int i=1;i<=10;i++)
            {
                multi = m * i;
                Console.WriteLine($"{m} * {i} = {multi}");
            }
            
        }
    }
}
