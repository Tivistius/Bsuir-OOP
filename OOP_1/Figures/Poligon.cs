using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1.Figures
{
    class Poligon : Figure
    {
        protected int _pointsNumber;
        public override int pointsNumber { get => _pointsNumber; }
        public Point[] points { get; set; } = new Point[3];
        public override void ChangeState(Point[] points)
        {
            this.points = points;
        }
        public Poligon(Color color, int Thicknes, Point[] points)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            _pointsNumber = points.Length;
            this.points = points;
        }
        public Poligon() : base() { }
    }
}
