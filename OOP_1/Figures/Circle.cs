using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    [Serializable]
    public class Circle : Elipse
    {
        public static new string name { get => "Круг"; } 
        public float diameter { get; set; }

        public override float width
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public override float height
        {
            get { return diameter; }
            set { diameter = value; }
        }
        public Circle() : base() { }
        public Circle(Color color, int thickness, PointF center, float diameter) : base(color, thickness, center, diameter, diameter){ }
        public Circle(Color color, int Thicknes, PointF[] points) {
            _PenColor = color;
            _PenThickness = Thicknes;
            center = new PointF(Math.Abs(points[1].X + points[0].X) / 2, Math.Abs(points[1].Y + points[0].Y) / 2);
            diameter = Math.Min(Math.Abs(points[1].X - points[0].X),Math.Abs(points[1].Y - points[0].Y));
        }
    }
}
