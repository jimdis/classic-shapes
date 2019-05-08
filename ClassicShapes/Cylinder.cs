using System;
namespace ClassicShapes
{
    /// <summary>
    /// Represents a Cylinder.
    /// </summary>
    public class Cylinder : Shape3D
    {
        /// <summary>
        ///     Initializes a new instance of the Cylinder class.
        /// </summary>
        /// <param name="hdiameter">Horizontal diameter of the Cylinder.</param>
        /// <param name="vdiameter">Vertical diameter of the Cylinder.</param>
        /// <param name="hdiameter">Height of the Cylinder.</param>

        public Cylinder(double hdiameter, double vdiameter, double height)
            : base(ShapeType.Cylinder, new Ellipse(hdiameter, vdiameter), height)
        { }
    }
}