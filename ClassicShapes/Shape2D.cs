using System;
namespace ClassicShapes
{
    public abstract class Shape2D : Shape
    {
        private double _length;
        private double _width;

        protected Shape2D(ShapeType shapeType, double length, double width) : base(shapeType)
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
                return "Formaterar med G";
            }
            if (format == "R")
            {
                return "Formaterar med R";
            }
            else
            {
                throw new FormatException("format argument not accepted.");
            }
        }

    }
}