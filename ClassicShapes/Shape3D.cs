using System;
namespace ClassicShapes
{
    public abstract class Shape3D : Shape
    {
        protected Shape2D _baseShape;
        private double _height;

        protected Shape3D(ShapeType shapeType, Shape2D baseShape, double height)
            : base(shapeType)
        {
            _baseShape = baseShape;
            Height = height;
        }

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
            }
        }

        public double Length
        {
            get => _baseShape.Length;
            set
            {
                _baseShape.Length = value;
            }
        }

        public virtual double MantelArea
        {
            get => _baseShape.Perimeter * Height;
        }

        public virtual double TotalSurfaceArea
        {
            get => MantelArea + 2 * _baseShape.Area;
        }

        public double Width
        {
            get => _baseShape.Width;
            set
            {
                _baseShape.Width = value;
            }
        }

        public virtual double Volume
        {
            get => _baseShape.Area * Height;
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