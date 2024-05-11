using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    [Serializable]
    public abstract class Poligon : Figure
    {
        public static new string name { get => "Полигон"; }
        protected int _PointsNumber;
        public override int PointsNumber { get => _PointsNumber; }
        public override PointF[] Points { get { return _Points; } }
        public override void ChangeState(PointF[] Points)
        {
            _Points = SortClockwise(Points);
        }
        public Poligon()
        {
            _PenColor = Color.Black;
            _PenThickness = 1;
        }
        public Poligon(Color color, int Thicknes, PointF[] Points)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            _PointsNumber = Points.Length;
            _Points = SortClockwise(Points);
        }
        public override bool IsPointFInFigure(PointF point)
        {
            int count = 0;

            for (int i = 0, j = _Points.Length - 1; i < _Points.Length; j = i++)
            {
                if (((_Points[i].Y > point.Y) != (_Points[j].Y > point.Y)) &&
                    (point.X < (_Points[j].X - _Points[i].X) * (point.Y - _Points[i].Y) / (_Points[j].Y - _Points[i].Y) + _Points[i].X))
                {
                    count++;
                }
            }

            return count % 2 != 0;
        }
        protected PointF FindCenter(PointF[] polygon)
        {
            float totalX = 0;
            float totalY = 0;

            foreach (var point in polygon)
            {
                totalX += point.X;
                totalY += point.Y;
            }

            return new PointF(totalX / _PointsNumber, totalY / _PointsNumber);
        }

        protected double Angle(PointF center, PointF p1, PointF p2)
        {
            double angle1 = Math.Atan2(p1.Y - center.Y, p1.X - center.X);
            double angle2 = Math.Atan2(p2.Y - center.Y, p2.X - center.X);
            return angle1 - angle2;
        }

        protected PointF[] SortClockwise(PointF[] polygon)
        {
            PointF center = FindCenter(polygon);

            Array.Sort(polygon, (p1, p2) =>
            {
                double angleDiff = Angle(center, p1, p2);
                if (angleDiff != 0)
                    return angleDiff > 0 ? -1 : 1;
                else
                {
                    double dist1 = Math.Sqrt(Math.Pow(p1.X - center.X, 2) + Math.Pow(p1.Y - center.Y, 2));
                    double dist2 = Math.Sqrt(Math.Pow(p2.X - center.X, 2) + Math.Pow(p2.Y - center.Y, 2));
                    return dist1 < dist2 ? -1 : 1;
                }
            });

            return polygon;
        }
    }
}
