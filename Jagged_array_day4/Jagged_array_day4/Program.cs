using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged_array_day4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Row, Column;
            Console.WriteLine("enter the rows in the jagged array");
            Row = Convert.ToInt32(Console.ReadLine());
            int[] column = new int[Row];
            int[][] jagged_array = new int[Row][];
            for (int i=0;i<Row;i++)
            {
                Console.Write($"enter the no of elements in Column {i + 1}: ");
                column[i] = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine($"enter the no of elements in Column {i+1} c[i]");
                //int[i] jag_array = new int[Convert.ToInt32(Console.ReadLine())];
            }
            Console.WriteLine("enter the values in jagged array");
            //int[][] jagged_array = new int[Row][];
            for (int i = 0; i < Row; i++)
            {
                jagged_array[i] = new int[column[i]];
            }
            for(int i=0;i<jagged_array.Length;i++)
            {
                for (int j = 0; j < jagged_array[i].Length; j++)
                {
                    jagged_array[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("the final jagged array is");
            for (int i = 0; i < jagged_array.Length; i++)
            {
                for (int j = 0; j < jagged_array[i].Length; j++)
                {
                    Console.Write(jagged_array[i][j]+" ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
