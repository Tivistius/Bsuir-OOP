using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    class Elipse : Figure
    {
        public override int pointsNumber { get => 2; }
        public Point center { get; set; }
        public virtual int width { get; set; }
        public virtual int height { get; set; }
        
        public override void ChangeState(Point[] points)
        {
            center = new Point(Math.Abs(points[1].X - points[0].X) / 2, Math.Abs(points[1].Y - points[0].Y) / 2);
            width = Math.Abs(points[1].X - points[0].X);
            height = Math.Abs(points[1].Y - points[0].Y);
        }
        public Elipse() : base() { }
        public Elipse(Color color, int Thicknes, Point center, int width, int height)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            this.height = height;
            this.width = width;
            this.center = center;
        }
        public Elipse(Color color, int Thicknes, Point[] points)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            center = new Point(Math.Abs(points[1].X + points[0].X)/2, Math.Abs(points[1].Y + points[0].Y)/2);
            width = Math.Abs(points[1].X - points[0].X);
            height = Math.Abs(points[1].Y - points[0].Y);
        }
    }
}
