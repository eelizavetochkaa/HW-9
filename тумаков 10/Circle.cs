using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_10
{
    public class Circle: Point
    {
        public int Radius { get; set; }

        public Circle(int x, int y, int radius, string color, bool isVisible) : base(x, y, color, isVisible)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
