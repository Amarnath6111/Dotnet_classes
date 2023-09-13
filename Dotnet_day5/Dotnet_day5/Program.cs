using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet_day5
{
    public class Access_spe
    {
        internal int Id;
        public string Name;
        private double Cgp;
        protected string Dept;
        internal protected int Total;
    }
    class Program
    {
        static void Main(string[] args) 
        {
            Access_spe obj1 = new Access_spe();
            obj1.Id = 103;
            obj1.Name = "amarnath";
            obj1.Total = 498;
            Console.WriteLine(obj1.Name)
            Console.ReadLine();

        }
    }
    class Protected_eg : Access_spe
    {
        static void Prot()
        {
            Access_spe obj1 = new Access_spe();
            obj1.Name = "hari";
            Protected_eg obj2 = new Protected_eg();
            obj2.Dept = "cse";
            obj2.Total = 467;


        }
    }
}
