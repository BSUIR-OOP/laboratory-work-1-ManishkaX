using System;
using System.Drawing;

namespace Lab_1
{
    public abstract class Figure
    {
        protected Tuple<int, int> _offset;


        public Color Color { get; set; }

        public double Thickness { get; set; }


        public Figure(Tuple<int, int> offset)
        {
            Color = Color.FromArgb(0, 0, 0);
            Thickness = 3;
            _offset = offset;
        }

        
        public abstract void Display();
    }
}
