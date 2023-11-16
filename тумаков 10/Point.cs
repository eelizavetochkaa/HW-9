using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_10
{
    public class Point: Figure
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y, string color, bool isVisible) : base(color, isVisible)
        {
            X = x;
            Y = y;
        }

        public override void MoveHorizontally(int distance)
        {
            X += distance;
        }

        public override void MoveVertically(int distance)
        {
            Y += distance;
        }

        public override void ChangeColor(string newColor)
        {
            Color = newColor;
        }
    }
}
