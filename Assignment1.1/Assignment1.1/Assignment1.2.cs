using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._1
{
    class Class1
    {
        static void Main()
        {
            Console.WriteLine("Enter the no of subjects");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            int sum = 0;
            Console.WriteLine("Enter the marks of subjects");
            for (int i = 0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr1[i];
            }
            Console.WriteLine("The total marks obtained : " + sum);
            double avg = sum / n;
            Console.WriteLine("The average of all subjects is " + avg);
            int max = arr1.Max();
            Console.WriteLine("The min marks obtained is " + max);
            int min = arr1.Min();
            Console.WriteLine("The min marks obtained is " + min);
            Array.Sort(arr1);
            Console.WriteLine("The Ascending order of marks ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr1[i]+" ");
            }
            Console.WriteLine();
            Array.Reverse(arr1);
            Console.WriteLine("The min marks obtained is " + arr1);
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr1[i]+" ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
