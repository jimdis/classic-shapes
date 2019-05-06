using System;
namespace ClassicShapes
{
    public abstract class Shape2D : Shape
    {
        private double _length;
        private double _width;

        private protected Shape2D(ShapeType ShapeType, double length, double width)
        {
            //Todo
        }

        public abstract double Area;

        public abstract double Perimeter;

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

        public string ToString()
        {
            return ToString("G");
        }

        public string ToString(string format = "G")
        {
            if (format == "G")
            {
                return "Formaterar med G";
            }
            if (format == "R")
            {
                return "Formaterar med R";
            }
            else
            {
                throw new FormatException("format argument not accepted.")
            }
        }

    }
}