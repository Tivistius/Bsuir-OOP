using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    [Serializable]
    public class Rectangle : Figure
    {
        public static new string name { get => "Прямоугольник"; }
        public override int PointsNumber { get => 2;}
        public override PointF[] Points
        {
            get
            {
                PointF[] res = new PointF[2];
                res[0] = leftUp;
                res[1] = new PointF(leftUp.X + width, leftUp.Y + height);
                return res;
            }
        }
        public PointF leftUp { get; set; }
        public virtual float width { get; set; }
        public virtual float height { get; set; }
        public override void ChangeState(PointF[] Points)
        {
            leftUp = new PointF(Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y));
            width = Math.Abs(Points[1].X - Points[0].X);
            height = Math.Abs(Points[1].Y - Points[0].Y);
        }
        public Rectangle() : base() { }
        public Rectangle(Color color, int Thicknes, PointF leftUp, float width, float height)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            this.height = height;
            this.width = width;
            this.leftUp = leftUp;
        }
        public Rectangle(Color color, int Thicknes, PointF[] Points)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            leftUp = new PointF(Math.Min(Points[0].X,Points[1].X), Math.Min(Points[0].Y, Points[1].Y));
            width = Math.Abs(Points[1].X-Points[0].X);
            height = Math.Abs(Points[1].Y - Points[0].Y);
        }

        public override bool IsPointFInFigure(PointF PointF)
        {
            if ((PointF.X > leftUp.X && PointF.X < leftUp.X+width) && (PointF.Y > leftUp.Y && PointF.Y < leftUp.Y + height))
            {
                return true;
            }
            else return false;
        }
    }
}
