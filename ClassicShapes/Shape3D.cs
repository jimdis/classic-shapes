using System;
namespace ClassicShapes
{
    /// <summary>
    /// Represents a 3D Shape.
    /// </summary>
    public abstract class Shape3D : Shape
    {
        protected Shape2D _baseShape;
        private double _height;

        /// <summary>
        ///     Constructor for the Shape3D class.
        /// </summary>
        /// <param name="shapeType">The ShapeType of the 3D shape.</param>
        /// <param name="baseShape">The Shape2D on which the 3D shape is built.</param>
        /// <param name="height">The height of the 3D shape.</param>
        protected Shape3D(ShapeType shapeType, Shape2D baseShape, double height)
            : base(shapeType)
        {
            _baseShape = baseShape;
            Height = height;
        }

        /// <summary>
        ///     Gets and sets the Height of the 3D shape.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if Height is set to <= 0.</exception>
        public double Height
        {
            get => _height;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Height must be greater than zero.");
                }

                _height = value;

                if (ShapeType == ShapeType.Sphere) _baseShape.Length = _baseShape.Width = value;
            }
        }

        /// <summary>
        ///     Gets and sets the Length of the 3D shape.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if Length is set to <= 0.</exception>
        public double Length
        {
            get => _baseShape.Length;
            set
            {
                _baseShape.Length = value;
                if (ShapeType == ShapeType.Sphere)
                {
                    _baseShape.Width = Height = value;
                }
            }
        }
        /// <summary>
        ///     Gets the Mantel Area of the 3D shape.
        /// </summary>
        public virtual double MantelArea
        {
            get => _baseShape.Perimeter * Height;
        }

        /// <summary>
        ///     Gets the Total Surface Area of the 3D shape.
        /// </summary>
        public virtual double TotalSurfaceArea
        {
            get => MantelArea + 2 * _baseShape.Area;
        }

        /// <summary>
        ///     Gets and sets the Width of the 3D shape.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if Width is set to <= 0.</exception>
        public double Width
        {
            get => _baseShape.Width;
            set
            {
                _baseShape.Width = value;
                if (ShapeType == ShapeType.Sphere)
                {
                    _baseShape.Length = Height = value;
                }
            }
        }

        /// <summary>
        ///     Gets the Volume of the 3D shape.
        /// </summary>
        public virtual double Volume
        {
            get => _baseShape.Area * Height;
        }

        /// <summary>
        ///     Converts this 3D shape to a human-readable string with a new line for each property of the 3D shape.
        /// </summary>
        /// <returns>A string representation of this 3D shape.</returns>
        public override string ToString() => ToString("G");

        /// <summary>
        ///     Converts this 3D shape to a human-readable string using specified format.
        /// </summary>
        /// <param name="format">A standard format string (see Remarks).</param>
        /// <returns>A string representation of this 3D shape.</returns>
        /// <remarks>
        ///     The ToString(String) method returns the string representation of a 3D shape in a specific
        ///     format.
        ///     The format parameter should contain a single format specifier character that defines the format of the returned
        ///     string. If format is null or an empty string, the format specifier, 'G', is used.
        ///     <list type="bullet">
        ///         <item>
        ///             "G" format specifier: Returns a string with a new line for each property of the 3D shape.
        ///         </item>
        ///         <item>
        ///             "R" format specifier: Returns a string with all properties of the 3D shape on a single line.
        ///         </item>
        ///     </list>
        /// </remarks>
        public override string ToString(string format)
        {
            string[] keys = { "Length", "Width", "Height", "Mantel Area", "Total Surface Area", "Volume" };
            double[] values = { Length, Width, Height, MantelArea, TotalSurfaceArea, Volume };
            if (format == "G" || String.IsNullOrEmpty(format))
            {
                int keyPadding = 20;
                int valuePadding = 8;

                string output = $"\n---------------------\n{ShapeType}\n---------------------\n";

                for (int i = 0; i < keys.Length; i++)
                {
                    output += String.Format("{0,-" + keyPadding + "} {1," + valuePadding + ":f1}\n", $"{keys[i]}:", values[i]);
                }

                output += "---------------------";

                return output;
            }
            if (format == "R")
            {
                string output = $"{ShapeType.ToString().PadRight(9)}";

                for (int i = 0; i < keys.Length; i++)
                {
                    output += String.Format("{0," + (keys[i].Length + 5) + ":f1}", values[i]);
                }
                return output;
            }
            else
            {
                throw new FormatException("format argument not accepted.");
            }
        }
    }
}