using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Rectangle:Ishape
    {
        int Len, Bre;
        public double GetArea()
        {
            Console.WriteLine("enter length and Breadth of Rectangle");
            Len = Convert.ToInt32(Console.ReadLine()); 
            Bre = Convert.ToInt32(Console.ReadLine());
            return Len *Bre ;
        }

        public double GetCircumference()
        {
            return 2 * (Len+Bre);
        }

        public string GetShape()
        {
            return "Rectangle";
        }
    }
}
