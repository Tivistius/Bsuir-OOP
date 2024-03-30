using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    class Triangle : OOP_1.Figures.Poligon
    {
        public override int pointsNumber { get => 3; }
        public Triangle(Color color, int Thicknes, Point[] points)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            this.points = new Point[pointsNumber];
            this.points[0] = points[0];
            this.points[1] = points[1];
            this.points[2] = points[2];
        }
        public Triangle() : base() { }
        public Triangle(Color color, int Thicknes, Point point1, Point point2, Point point3)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            points = new Point[pointsNumber];
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
        }
    }
}
