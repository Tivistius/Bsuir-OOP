using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    [Serializable]
    public class Square : Rectangle
    {
        public static new string name { get => "Квадрат"; }
        public float size { get; set; }
        public override float width
        {
            get { return size; }
            set { size = value; }
        }

        public override float height
        {
            get { return size; }
            set { size = value; }
        }
        public Square() : base() { }
        public Square(Color color, int thickness, PointF center, int size) : base(color, thickness, center, size, size){ }
        public Square(Color color, int Thicknes, PointF[] Points)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            leftUp = new PointF(Math.Min(Points[0].X, Points[1].X), Math.Min(Points[0].Y, Points[1].Y));
            size = Math.Min(Math.Abs(Points[1].X - Points[0].X), Math.Abs(Points[1].Y - Points[0].Y));
        }
    }
}
