using System;

namespace Lab_1
{
    class RegularPolygon : Figure
    {
        private int _countOfEdges;
        private int _lengthOfEdge;


        public RegularPolygon(Tuple<int, int> offset, int countOfEdges, int lengthOfEdge) : base(offset)
        {
            _countOfEdges = countOfEdges;
            _lengthOfEdge = lengthOfEdge;
        }

        public override void Display() =>
           Console.WriteLine($"Regular Polygon ({_offset.Item1}, {_offset.Item2}) with {_countOfEdges} edges and {_lengthOfEdge} length of each."); 
    }
}
