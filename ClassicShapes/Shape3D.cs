using System;
using System.Linq;
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
                if (ShapeType == ShapeType.Sphere)
                {
                    _baseShape.Length = value;
                    _baseShape.Width = value;
                }
            }
        }

        public double Length
        {
            get => _baseShape.Length;
            set
            {
                _baseShape.Length = value;
                if (ShapeType == ShapeType.Sphere)
                {
                    _baseShape.Width = value;
                    Height = value;
                }
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
                if (ShapeType == ShapeType.Sphere)
                {
                    _baseShape.Length = value;
                    Height = value;
                }
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