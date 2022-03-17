using System;

namespace Lab_1
{
    class Ellipse : Figure
    {
        private int _axisX;
        private int _axisY;


        public Ellipse(Tuple<int, int> offset, int axisX, int axisY) : base(offset)
        {
            _axisX = axisX;
            _axisY = axisY;
        }

        public override void Display() =>
            Console.WriteLine($"Ellipse ({_offset.Item1 + _axisX / 2}, {_offset.Item2 + _axisY / 2}), Axis X - {_axisX}, Axis Y - {_axisY}");
    }
}
