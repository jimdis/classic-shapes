using System;
namespace ClassicShapes
{
    public class Sphere : Shape3D
    {
        public Sphere(double diameter)
            : base(ShapeType.Sphere, new Ellipse(diameter), diameter)
        { }

        public double Diameter
        {
            get => this.Height;

            set
            {
                this.Height = value;
                this.Width = value;
                this.Length = value;
            }
        }

        public override double MantelArea
        {
            get => this._baseShape.Area * 4;
        }

        public override double TotalSurfaceArea
        {
            get => MantelArea;
        }

        public override double Volume
        {
            get => (4 / 3) * this._baseShape.Area * (Diameter / 2);
        }
    }
}