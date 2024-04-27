using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    [Serializable]
    public class Elipse : Figure
    {
        public static new string name { get => "Эллипс"; }
        public override int PointsNumber { get => 2; }
        public override PointF[] Points
        {
            get
            {
                PointF[] res = new PointF[2];
                res[0] = new PointF(center.X - width/2, center.Y - height/2);
                res[1] = new PointF(center.X + width/2, center.Y + height/2);
                return res;
            }
        }
        public PointF center { get; set; }
        public virtual float width { get; set; }
        public virtual float height { get; set; }
        
        public override void ChangeState(PointF[] Points)
        {
            center = new PointF(Math.Abs(Points[1].X + Points[0].X) / 2, Math.Abs(Points[1].Y + Points[0].Y) / 2);
            width = Math.Abs(Points[1].X - Points[0].X);
            height = Math.Abs(Points[1].Y - Points[0].Y);
        }
        public Elipse() : base() { }
        public Elipse(Color color, int Thicknes, PointF center, float width, float height)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            this.height = height;
            this.width = width;
            this.center = center;
        }
        public Elipse(Color color, int Thicknes, PointF[] Points)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            center = new PointF(Math.Abs(Points[1].X + Points[0].X)/2, Math.Abs(Points[1].Y + Points[0].Y)/2);
            width = Math.Abs(Points[1].X - Points[0].X);
            height = Math.Abs(Points[1].Y - Points[0].Y);
        }

        public override bool IsPointFInFigure(PointF PointF)
        {
            float a = width / 2;
            float b = height / 2;

            float x = PointF.X - center.X;
            float y = PointF.Y - center.Y;

            return ((x * x) / (a * a)) + ((y * y) / (b * b)) <= 1;
        }
    }
}
