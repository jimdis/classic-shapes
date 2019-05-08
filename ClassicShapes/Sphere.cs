using System;
namespace ClassicShapes
{
    /// <summary>
    /// Represents a Sphere.
    /// </summary>
    public class Sphere : Shape3D
    {
        /// <summary>
        ///     Initializes a new instance of the Sphere class.
        /// </summary>
        /// <param name="diameter">Diameter of the Sphere.</param>
        public Sphere(double diameter)
            : base(ShapeType.Sphere, new Ellipse(diameter), diameter)
        { }


        /// <summary>
        ///     Gets and sets the Diameter of the Sphere.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if Diameter is set to <= 0.</exception>
        public double Diameter
        {
            get => Height;

            set { Height = Width = Length = value; }
        }

        /// <summary>
        ///     Gets the Mantel Area of the Sphere.
        /// </summary>
        public override double MantelArea
        {
            get => _baseShape.Area * 4;
        }

        /// <summary>
        ///     Gets the Total Surface Area of the Sphere.
        /// </summary>
        public override double TotalSurfaceArea
        {
            get => MantelArea;
        }

        /// <summary>
        ///     Gets the Volume of the Sphere.
        /// </summary>
        public override double Volume
        {
            get => (4 / 3) * _baseShape.Area * (Diameter / 2);
        }
    }
}