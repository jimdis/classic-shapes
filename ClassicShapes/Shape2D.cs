using System;
using System.Collections.Generic;
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
            if (format == "G" || String.IsNullOrEmpty(format))
            {
                string[] keys = { "Längd", "Bredd", "Omkrets", "Area" };
                double[] values = { Length, Width, Perimeter, Area };
                int maxLength = (int)values.Max().ToString().Length;
                int padding = maxLength < 10 ? 10 : maxLength;
                string align = "{0,-" + padding + "} {1," + padding + ":f1}\n";

                String output = $"\n{ShapeType}\n---------------\n";

                for (int i = 0; i < keys.Length; i++)
                {
                    output += String.Format(align, $"{keys[i]}:", values[i]);
                }

                return output;
            }
            if (format == "R")
            {
                return $"{ShapeType}\t{Length:f1}\t{Width:f1}\t{Perimeter:f1}\t{Area:f1}";
            }
            else
            {
                throw new FormatException("format argument not accepted.");
            }
        }
    }
}