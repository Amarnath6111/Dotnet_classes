using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodebaseTest3
{
    class Box
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        public Box(double len,double bre)
        {
            Length = len;
            Breadth = bre;
        }
        public static  Box Add(Box obj_box1,Box obj_box2)
        {
            double Final_length = obj_box1.Length + obj_box2.Length;
            double Final_breadth = obj_box1.Breadth + obj_box2.Breadth;
            Console.WriteLine("after adding the two box objects the result of third box is: ");
            return new Box(Final_length, Final_breadth);
        }
        public  void Show()
        {
            Console.WriteLine($"length is: {Length} \n Breadth is: {Breadth}");
        }

    }
    class Test
    {
        public static void Main()
        {
            Console.Write($"enter the Length of First box: ");
            int Len1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write($"enter the Breadth of First box ");
            int Bre1= Convert.ToInt32(Console.ReadLine());
            Console.Write($"enter the Length of Second box: ");
            int Len2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write($"enter the Breadth of Second box ");
            int Bre2 = Convert.ToInt32(Console.ReadLine());
            Box obj_box1 = new Box(Len1, Bre1);
            Box obj_box2 = new Box(Len2, Bre2);
            Box box3 = Box.Add(obj_box1, obj_box2);
            box3.Show();
            Console.ReadLine();

        }
    }
}
