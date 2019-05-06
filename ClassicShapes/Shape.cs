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
                String[] are3D = { "Cuboid", "Cylinder", "Sphere" };
                return are3D.Contains(ShapeType.ToString());
            }
        }

        public ShapeType ShapeType { get; private set; }

        public abstract string ToString(string format);
    }
}