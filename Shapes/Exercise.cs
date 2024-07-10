using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Exercise
    {
        public void PrintAreas() 
        {
            List<IShape> shapes = new List<IShape>();
            IShape shape1 = new Circle(5);
            IShape shape2 = new Rectangle(4,6);
            Console.WriteLine($"Circle Area: {shape1.GetArea()}");
            Console.WriteLine($"Rectangle Area: {shape2.GetArea()}");

        }
    }
}
