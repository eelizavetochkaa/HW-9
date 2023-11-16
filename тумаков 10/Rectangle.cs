using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_10
{
    public class Rectangle: Point
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(int x, int y, int w, int h, string color, bool isVisible) : base(x, y, color, isVisible)
        {
            Width = w;
            Height = h;
        }

        public int CalculateArea()
        {
            return Width * Height;
        }
    }
}
