using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_dotnet_5
{
    class Occurrence
    {
        public static void Letter()
        {
            int count = 0;
            Console.WriteLine("enter the string");
            string str1 = (Console.ReadLine()).ToUpper();
            Console.WriteLine("enter the character to find the occurrence");
            string str2= (Console.ReadLine()).ToUpper();
            char Letter = Convert.ToChar(str2);
            for(int i=0;i<str1.Length;i++)
            {
                if(str1[i]==Letter)
                {
                    count+=1;
                }
            }
            Console.WriteLine($"{Letter} appears {count} times in {str1}");
        }
    }
}
