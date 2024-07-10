using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double radius) 
        {
            Radius = radius;
        }

        

        public double GetArea()
        {
            return Radius*Radius*3.14;
        }
    }
}
