using System;
namespace ClassicShapes
{
    /// <summary>
    /// Represents an Ellipse.
    /// </summary>
    public class Ellipse : Shape2D
    {
        /// <summary>
        ///     Initializes a new instance of the Ellipse class.
        /// </summary>
        /// <param name="hdiameter">Horizontal Diameter of the Ellipse.</param>
        /// <param name="vdiameter">Vertical Diameter of the Ellipse.</param>
        public Ellipse(double hdiameter, double vdiameter)
            : base(ShapeType.Ellipse, hdiameter, vdiameter)
        { }

        /// <summary>
        ///     Initializes a new instance of the Ellipse class representing a circle.
        /// </summary>
        /// <param name="diameter">Diameter of the Ellipse.</param>
        public Ellipse(double diameter)
            : base(ShapeType.Ellipse, diameter, diameter)
        { }

        /// <summary>
        ///     Gets the Area of the Ellipse.
        /// </summary>
        public override double Area
        {
            get => Math.PI * (Length * Width) / 4;
        }

        /// <summary>
        ///     Gets the Perimeter of the Ellipse.
        /// </summary>
        public override double Perimeter
        {
            get => (
                Math.PI *
                Math.Sqrt(2 * (Math.Pow(Length / 2, 2) + Math.Pow(Width / 2, 2)))
            );
        }
    }
}