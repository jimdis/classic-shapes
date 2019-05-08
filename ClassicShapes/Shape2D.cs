using System;
namespace ClassicShapes
{
    /// <summary>
    /// Represents a 2D Shape.
    /// </summary>
    public abstract class Shape2D : Shape
    {
        private double _length;
        private double _width;

        /// <summary>
        ///     Constructor for the Shape2D class.
        /// </summary>
        /// <param name="shapeType">The ShapeType of the 2D shape.</param>
        /// <param name="length">The length of the 2D shape.</param>
        /// <param name="width">The width of the 2D shape.</param>
        protected Shape2D(ShapeType shapeType, double length, double width)
            : base(shapeType)
        {
            Length = length;
            Width = width;
        }

        /// <summary>
        ///     Gets the Area of the 2D shape.
        /// </summary>
        public abstract double Area { get; }

        /// <summary>
        ///     Gets the Perimeter of the 2D shape.
        /// </summary>
        public abstract double Perimeter { get; }

        /// <summary>
        ///     Gets and sets the Length of the 2D shape.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if Length is set to <= 0.</exception>
        public double Length
        {
            get => _length;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Length must be greater than zero.");
                }
                _length = value;
            }
        }

        /// <summary>
        ///     Gets and sets the Width of the 2D shape.
        /// </summary>
        /// <exception cref="ArgumentOutOfRangeException">Thrown if Width is set to <= 0.</exception>
        public double Width
        {
            get => _width;

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Width must be greater than zero.");
                }
                _width = value;
            }
        }

        /// <summary>
        ///     Converts this 2D shape to a human-readable string with a new line for each property of the 2D shape.
        /// </summary>
        public override string ToString()
        {
            return ToString("G");
        }

        /// <summary>
        ///     Converts this 2D shape to a human-readable string using specified format.
        /// </summary>
        /// <param name="format">A standard format string (see Remarks).</param>
        /// <returns>A string representation of this 2D shape.</returns>
        /// <remarks>
        ///     The ToString(String) method returns the string representation of a 2D shape in a specific
        ///     format.
        ///     The format parameter should contain a single format specifier character that defines the format of the returned
        ///     string. If format is null or an empty string, the format specifier, 'G', is used.
        ///     <list type="bullet">
        ///         <item>
        ///             "G" format specifier: Returns a string with a new line for each property of the 2D shape.
        ///         </item>
        ///         <item>
        ///             "R" format specifier: Returns a string with all properties of the 2D shape on a single line.
        ///         </item>
        ///     </list>
        /// </remarks>
        public override string ToString(string format)
        {
            string[] keys = { "Length", "Width", "Perimeter", "Area" };
            double[] values = { Length, Width, Perimeter, Area };
            if (format == "G" || String.IsNullOrEmpty(format))
            {
                int padding = 10;
                string align = "{0,-" + padding + "} {1," + padding + ":f1}\n";

                string output = $"\n---------------------\n{ShapeType}\n---------------------\n";

                for (int i = 0; i < keys.Length; i++)
                {
                    output += String.Format(align, $"{keys[i]}:", values[i]);
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