using System;
namespace ClassicShapes
{
    public class Cylinder : Shape3D
    {
        public Cylinder(double hdiameter, double vdiameter, double height)
            : base(ShapeType.Cylinder, new Ellipse(hdiameter, vdiameter), height)
        { }
    }
}