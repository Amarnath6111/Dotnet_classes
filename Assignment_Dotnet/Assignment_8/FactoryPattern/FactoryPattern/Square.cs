using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Square : Ishape
    {

        int Len;
        public double GetArea()
        {
            Console.WriteLine("enter length of square");
            int Len = Convert.ToInt32(Console.ReadLine());
            return Len * Len;
        }

        public double GetCircumference()
        {
            return 4 * Len;
        }

        public string GetShape()
        {
            return "Square";
        }
    }
}
