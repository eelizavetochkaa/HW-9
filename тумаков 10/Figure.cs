using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace тумаков_10
{
    public abstract class Figure
    {
        public string Color { get; set; }
        public bool IsVisible { get; set; }

        public Figure(string color, bool isVisible)
        {
            Color = color;
            IsVisible = isVisible;
        }

        public abstract void MoveHorizontally(int distance);
        public abstract void MoveVertically(int distance);
        public abstract void ChangeColor(string newColor);

        public void DisplayStatus()
        {
            Console.WriteLine($"Цвет: {Color}, видимость: {(IsVisible ? "видимый" : "невидимый")}");
        }
    }
}
