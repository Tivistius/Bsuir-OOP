using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    [Serializable]
    public class Triangle : Poligon
    {
        public static new string name { get => "Треугольник"; }
        public override int PointsNumber { get => 3; }
        public Triangle(Color color, int Thicknes, PointF[] Points)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            _Points = new PointF[PointsNumber];
            _Points[0] = Points[0];
            _Points[1] = Points[1];
            _Points[2] = Points[2];
        }
        public Triangle() : base() { }
        public Triangle(Color color, int Thicknes, PointF Point1, PointF Point2, PointF Point3)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            _Points = new PointF[PointsNumber];
            _Points[0] = Point1;
            _Points[1] = Point2;
            _Points[2] = Point3;
        }
    }
}
