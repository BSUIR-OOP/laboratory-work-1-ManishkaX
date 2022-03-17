using System;

namespace Lab_1
{
    public class Triangle : Figure
    {
        private Tuple<int, int>[] _vertices;


        public Triangle(Tuple<int, int> offset, Tuple<int, int> p1, Tuple<int, int> p2, Tuple<int, int> p3) : base(offset)
        {
            _vertices = new Tuple<int, int>[3] { p1, p2, p3 };
            //Array.Sort(_vertices, (p1, p2) => p1.Item1.CompareTo(p2.Item1));
        }

        public override void Display() =>
            Console.WriteLine($"Triangle ({_vertices[0].Item1}, {_vertices[0].Item2}), ({_vertices[1].Item1}, {_vertices[1].Item2}), ({_vertices[2].Item1}, {_vertices[2].Item2})");
    }
}

