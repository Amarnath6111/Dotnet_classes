using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Circle : Ishape
    {
        int radius;
        public double GetArea()
        {
            Console.WriteLine("enter radius of cicle");
            int radius= Convert.ToInt32(Console.ReadLine());
            return Math.PI * radius * radius;
        }

        public double GetCircumference()
        {
            return 2 * Math.PI * radius;
        }
        public string GetShape()
        {
            return "Circle";
        }
    }
}