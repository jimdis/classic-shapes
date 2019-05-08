using System;
namespace ClassicShapes
{
    /// <summary>
    /// Represents a Cuboid.
    /// </summary>
    public class Cuboid : Shape3D
    {
        /// <summary>
        ///     Initializes a new instance of the Cuboid class.
        /// </summary>
        /// <param name="length">Length of the Cuboid.</param>
        /// <param name="width">Width of the Cuboid.</param>
        /// <param name="hdiameter">Height of the Cuboid.</param>
        public Cuboid(double length, double width, double height)
            : base(ShapeType.Cuboid, new Rectangle(length, width), height)
        { }
    }
}