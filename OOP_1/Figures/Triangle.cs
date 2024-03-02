using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    class Triangle : Figure
    {
        public Point[] points { get; set; } = new Point[3];
        public override void Draw(Graphics g)
        {
            g.DrawLine(p, points[0], points[1]);
            g.DrawLine(p, points[1], points[2]);
            g.DrawLine(p, points[2], points[0]);
        }
        public Triangle() : base() { }
        public Triangle(Color color, int Thicknes, Point point1, Point point2, Point point3)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            points[0] = point1;
            points[1] = point2;
            points[2] = point3;
            p = new Pen(color, Thicknes);
        }
    }
}
