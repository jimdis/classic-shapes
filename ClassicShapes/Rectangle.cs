using System;
namespace ClassicShapes
{
    public class Rectangle : Shape2D
    {
        public Rectangle(double length, double width) : base(ShapeType.Rectangle, length, width)
        { }

        public override double Area
        {
            get => Length * Width;
        }

        public override double Perimeter
        {
            get => 2 * Length + 2 * Width;
        }

    }
}