using System;

namespace Lab_1
{
    class Circle: Figure
    {
        private int _radius;

 
        public Circle(Tuple<int, int> offset, int radius) : base(offset) => _radius = radius;

        public override void Display() =>
            Console.WriteLine($"Circle ({_offset.Item1}, {_offset.Item2}) and Radius = {_radius}");
    }
}
