using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    class Rectangle : Figure
    {
        public override int pointsNumber { get => 2;}
        public Point leftUp { get; set; }
        public virtual int width { get; set; }
        public virtual int height { get; set; }
        public override void ChangeState(Point[] points)
        {
            leftUp = points[0];
            width = Math.Abs(points[1].X - points[0].X);
            height = Math.Abs(points[1].Y - points[0].Y);
        }
        public Rectangle() : base() { }
        public Rectangle(Color color, int Thicknes, Point leftUp, int width, int height)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            this.height = height;
            this.width = width;
            this.leftUp = leftUp;
        }
        public Rectangle(Color color, int Thicknes, Point[] points)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            leftUp = new Point(Math.Min(points[0].X,points[1].X), Math.Min(points[0].Y, points[1].Y));
            width = Math.Abs(points[1].X-points[0].X);
            height = Math.Abs(points[1].Y - points[0].Y);
        }
    }
}
