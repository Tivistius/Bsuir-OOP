using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    class Square : Rectangle
    {
        public int size { get; set; }
        public override int width
        {
            get { return size; }
            set { size = value; }
        }

        public override int height
        {
            get { return size; }
            set { size = value; }
        }
        public Square() : base() { }
        public Square(Color color, int thickness, Point center, int size) : base(color, thickness, center, size, size){ }
        public Square(Color color, int Thicknes, Point[] points)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            leftUp = points[0];
            size = Math.Min(Math.Abs(points[1].X - points[0].X), Math.Abs(points[1].Y - points[0].Y));
        }
    }
}
