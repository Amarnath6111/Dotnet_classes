using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseTest3
{
    class Cricket
    {
        public static void Pointscalculation(int no_of_matches)
        {
            int[] ScoresArr = new int[no_of_matches];
            Console.WriteLine("enter the scores of each match");
            int temp = 0;
            int sum = 0;
            double Avg = 0;
            for(int i=0;i<no_of_matches;i++)
            {
                Console.Write($"enter the score of {i+1} Match: ");
                temp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                ScoresArr[i] = temp;

            }
            Avg = ScoresArr.Average();
            sum = ScoresArr.Sum();
            Console.WriteLine($"The Average score of {no_of_matches} is: {Avg} and totalscore of all the matches is: {sum}");
            
            
        }
        static void Main(string[] args)
        {
            Console.Write("Enter the no of Matches: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Pointscalculation(n);
            Console.ReadKey();
        }
    }
}
