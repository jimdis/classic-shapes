using System;
namespace ClassicShapes
{
    public class Ellipse : Shape2D
    {
        public Ellipse(double hdiameter, double vdiameter)
            : base(ShapeType.Ellipse, hdiameter, vdiameter)
        { }

        public Ellipse(double diameter)
            : base(ShapeType.Ellipse, diameter, diameter)
        { }

        public override double Area
        {
            get => Math.PI * (Length * Width) / 4;
        }

        public override double Perimeter
        {
            get => (
                Math.PI *
                Math.Sqrt(
                    2 * (Math.Pow(Length / 2, 2) + Math.Pow(Width / 2, 2))
                )
            );
        }
    }
}