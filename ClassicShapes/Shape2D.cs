using System;
using System.Linq;
namespace ClassicShapes
{
    public abstract class Shape2D : Shape
    {
        private double _length;
        private double _width;

        protected Shape2D(ShapeType shapeType, double length, double width)
            : base(shapeType)
        {
            Length = length;
            Width = width;
        }

        public abstract double Area { get; }

        public abstract double Perimeter { get; }

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

        public override string ToString()
        {
            return ToString("G");
        }

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