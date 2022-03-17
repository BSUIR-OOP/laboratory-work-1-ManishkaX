using System;

namespace Lab_1
{
    class Rectangle : Figure
    {
        private int _width;
        private int _height;

        public Rectangle(Tuple<int, int> offset, int width, int heigth) : base(offset)
        {
            _width = width;
            _height = heigth;
        }

        public override void Display() =>
            Console.WriteLine($"Rectangle ({_offset.Item1}, {_offset.Item2}), ({_offset.Item1 +_width}, {_offset.Item2 + _height})");
    }
}
