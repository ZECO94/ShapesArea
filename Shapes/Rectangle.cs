using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle : IShape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        
        public Rectangle(int width , int height)
        {
            Width = width;
            Height = height;
        }
        public double GetArea()
        {
            return Width * Height;
        }
    }
}
