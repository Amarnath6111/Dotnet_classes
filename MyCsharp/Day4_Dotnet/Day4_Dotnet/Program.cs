using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_Dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no of rows and columns");
            int r = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int[,] arr1 = new int [r,c];
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    arr1[i,j]= Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(arr1[i,j]);
                }
            }
            Console.ReadLine();

        }
    }
}
