using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter Shape type :");
            string ShapeType = Console.ReadLine();

            Ishape sh = ShapeFactory.GetTheShape(ShapeType);

                if (sh != null)
                {
                    Console.WriteLine("Shape Type : {0}", sh.GetShape());
                    Console.WriteLine("Area : {0}", sh.GetArea());
                    Console.WriteLine("Circumference : {0}", sh.GetCircumference());
                }
                else
                {
                    Console.WriteLine("Invalid Card.. please give correct type");
                }
                Console.Read();
        }
        
    }
}
