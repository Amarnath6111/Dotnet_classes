using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class ShapeFactory
    {
        public static Ishape GetTheShape(string shapeType)
        {
            Ishape ISh = null;
            if (shapeType == "Circle")
            {
                ISh = new Circle();
            }
            else if (shapeType == "Rectangle")
            {
                ISh = new Rectangle();
            }
            else if (shapeType == "Square")
            {
                ISh = new Square();
            }
            return ISh;
        }
    }
}
