using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.Avg_MinMax();
        }
        static void Avg_MinMax()
        {
            int sum=0;
            Console.WriteLine("enter the length of array");
            int n= Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[n];
            Console.WriteLine("enter the values");
            for (int i=0; i < n; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
                sum += arr1[i];

            }
            int avg = sum / n;
            int max = arr1.Max();
            int min = arr1.Min();
            Console.WriteLine($"avg of the array is {avg}");
            Console.WriteLine($"the max value is {max} and the min value is {min}");
            Console.ReadLine();
        }
    }
}
