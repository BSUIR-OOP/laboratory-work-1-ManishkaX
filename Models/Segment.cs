using System;

namespace Lab_1
{
    class Segment : Figure
    {
        private Tuple<int, int> _point;

        public Segment(Tuple<int, int> offset, Tuple<int, int> point) : base(offset) =>
            _point = point;


        public override void Display() =>
            Console.WriteLine($"Segment ({_offset.Item1}, {_offset.Item2}), ({_point.Item1}, {_point.Item2})");
    }
}
