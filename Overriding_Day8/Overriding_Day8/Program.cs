using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding_Day8
{

    class Shape
    {
        protected int L=8, B, H;
        public virtual float SurfaceArea()
        {
            return 6 * L * L;
        }
        public virtual float Volume()
        {
            return L * L * L;

        }

    }
    class Cube : Shape
    {
        public void GetLength()
        {
            Console.WriteLine("enter the length of a cube");
            L = Convert.ToInt32(Console.ReadLine());
            //Shape shape = new Shape();
            //SurfaceArea();
            //Volume();
            //Console.WriteLine($"the surface area of cube is{SurfaceArea()} and volume is { Volume()}");
        }
    }
    class cuboid : Shape
    {
        public void GetValues()
        {
            Console.WriteLine("enter the length, breadth and height of a cuboid");
            L = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            H = Convert.ToInt32(Console.ReadLine());
        }
        public override float SurfaceArea()
        {
            GetValues();
            return 2 * ((L * B) + (L * H) + (B * H));
        }
        public override float Volume()
        {
            GetValues();
            return L * B * H;

        }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("details of shape");
                Shape shape = new Shape();
                Console.WriteLine($"the surface area of cube is {shape.SurfaceArea()}");
                Console.WriteLine($"the volume of cube is {shape.Volume()}");
                Cube shape1 = new Cube();
                shape1.GetLength();
                Console.WriteLine($"the surface area of cube is {shape1.SurfaceArea()}");
                Console.WriteLine($"the volume of cube is {shape1.Volume()}");
                shape = new cuboid();
                Console.WriteLine($"the surface area of cuboid is {shape.SurfaceArea()}");
                Console.WriteLine($"the volume of cuboid is {shape.Volume()}");
                Console.ReadLine();



            }
        }
    }
}
