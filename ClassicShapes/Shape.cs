using System;
using System.Linq;

namespace ClassicShapes
{
    /// <summary>
    /// Represents a Shape.
    /// </summary>
    public abstract class Shape
    {

        /// <summary>
        ///     Constructor for the Shape class.
        /// </summary>
        /// <param name="shapeType">The ShapeType of the Shape.</param>
        protected Shape(ShapeType shapeType)
        {
            ShapeType = shapeType;
        }

        /// <summary>
        ///     Gets if the Shape is a Shape3D or not.
        /// </summary>
        public bool Is3D
        {
            get
            {
                String[] are3D = { "Cuboid", "Cylinder", "Sphere" };
                return are3D.Contains(ShapeType.ToString());
            }
        }

        /// <summary>
        ///     Gets and sets the ShapeType of the Shape.
        /// </summary>
        public ShapeType ShapeType { get; private set; }

        /// <summary>
        ///     Converts this Shape to a human-readable string using specified format.
        /// </summary>
        /// <param name="format">Format for the string.</param>
        /// <returns>A string representation of the Shape.</returns>
        public abstract string ToString(string format);
    }
}