using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    class Circle : Elipse
    {
        public int diameter { get; set; }

        public override int width
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public override int height
        {
            get { return diameter; }
            set { diameter = value; }
        }
        public Circle() : base() { }
        public Circle(Color color, int thickness, Point center, int diameter) : base(color, thickness, center, diameter, diameter){ }
        public Circle(Color color, int Thicknes, Point[] points) {
            _PenColor = color;
            _PenThickness = Thicknes;
            center = new Point(Math.Abs(points[1].X + points[0].X) / 2, Math.Abs(points[1].Y + points[0].Y) / 2);
            diameter = Math.Min(Math.Abs(points[1].X - points[0].X),Math.Abs(points[1].Y - points[0].Y));
        }
    }
}
