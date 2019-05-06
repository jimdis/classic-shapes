using System;
using System.Linq;

namespace ClassicShapes
{
    public abstract class Shape
    {

        protected Shape(ShapeType shapeType)
        {
            ShapeType = shapeType;
        }

        public bool Is3D
        {
            get
            {
                String[] shapes3D = { "Cuboid", "Cylinder", "Sphere" };
                if (shapes3D.Contains(ShapeType.ToString()))
                {
                    return true;
                }
                else return false;
            }
        }
        public ShapeType ShapeType { get; private set; }

        public abstract string ToString(string format);
    }
}