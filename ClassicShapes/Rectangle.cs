using System;
namespace ClassicShapes
{
    /// <summary>
    /// Represents a Rectangle.
    /// </summary>
    public class Rectangle : Shape2D
    {
        /// <summary>
        ///     Initializes a new instance of the Rectangle class.
        /// </summary>
        /// <param name="length">Length of the Rectangle.</param>
        /// <param name="width">Width of the Rectangle.</param>
        public Rectangle(double length, double width)
            : base(ShapeType.Rectangle, length, width)
        { }


        /// <summary>
        ///     Gets the Area of the Rectangle.
        /// </summary>
        public override double Area
        {
            get => Length * Width;
        }

        /// <summary>
        ///     Gets the Perimeter of the Rectangle.
        /// </summary>
        public override double Perimeter
        {
            get => 2 * Length + 2 * Width;
        }
    }
}