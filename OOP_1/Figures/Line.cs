using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    class Line : Figure
    {
        public Point[] points { get; set; } = new Point[2];
        public override void Draw(Graphics g)
        {
            g.DrawLine(p, points[0], points[1]);
        }
        public Line() : base() { }
        public Line(Color color, int Thicknes, Point point1, Point point2)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            points[0] = point1;
            points[1] = point2;
            p = new Pen(color, Thicknes);
        }
    }
}
