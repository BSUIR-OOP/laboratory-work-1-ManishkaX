using System;

namespace Lab_1
{
    class Program
    {
        static void Main(string[] args)
        {
            FigureCollection figures = new FigureCollection();
            figures.Add(new Circle(new Tuple<int, int>(20, 20), 10));
            figures.Add(new Ellipse(new Tuple<int, int>(30,40), 20, 10));
            figures.Add(new Rectangle(new Tuple<int,int>(15,46), 13, 21));
            figures.Add(new Triangle(new Tuple<int, int>(80, 79), new Tuple<int, int>(84, 82), new Tuple<int, int>(4, 28), new Tuple<int, int>(47, 26)));
            figures.Add(new Segment(new Tuple<int, int>(12, 48), new Tuple<int, int>(123, 15)));
            figures.Add(new RegularPolygon(new Tuple<int, int>(4, 35), 62, 37));

            figures.Display();
        }
    }
}
