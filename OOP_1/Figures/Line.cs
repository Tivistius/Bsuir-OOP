using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    [Serializable]
    public class Line : Poligon
    {
        public static new string name { get => "Линия"; }
        public override int PointsNumber { get => 2; }
        public Line() : base() { }
        public Line(Color color, int Thicknes, PointF[] Points)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            _Points = new PointF[PointsNumber];
            _Points[0] = Points[0];
            _Points[1] = Points[1];
        }
        public Line(Color color, int Thicknes, PointF Point1, PointF Point2)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            _Points = new PointF[PointsNumber];
            _Points[0] = Point1;
            _Points[1] = Point2;
        }
        public override bool IsPointFInFigure(PointF PointF)
        {
            float numerator = Math.Abs((_Points[0].Y - _Points[1].Y) * PointF.X - (_Points[0].X - _Points[1].X) * PointF.Y + _Points[0].X * _Points[1].Y - _Points[0].Y * _Points[1].X);
            float denominator = (float)Math.Sqrt(Math.Pow(_Points[0].Y - _Points[1].Y, 2) + Math.Pow(_Points[0].X - _Points[1].X, 2));
            return numerator / denominator <= _PenThickness / 2; ;
        }
    }
}
