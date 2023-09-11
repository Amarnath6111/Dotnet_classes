using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment3
{
    class Assign3
    {
        static void Main(string[] args)
        {
            Assign3.Word();
            Assign3.Equal();
            Console.ReadLine();

        }
        static void Word()
        {
            Console.WriteLine("enter a word");
            string str = Console.ReadLine();
            int n = str.Length;
            Console.WriteLine($"the length of {str} is {n}");
            string str_rev = " ";
            for (int i = (n - 1); i >= 0; i--)
            {
                str_rev += str[i];
            }
            Console.WriteLine($"the reverse of {str} is {str_rev}");

        }
        public static void Equal()
        {
            Console.WriteLine("enter two words");
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            if (str1 == str2)
            {
                Console.WriteLine($"the two words {str1} and {str2} are equal");
            }
            else
            {
                Console.WriteLine($"the two words {str1} and {str2} are not equal");
            }
        }
    }
}
