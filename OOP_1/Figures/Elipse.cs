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
        public Point Center { get; set; }
        public uint width { get; set; }
        public uint height { get; set; }
        public override void Draw(Graphics g)
        {
            RectangleF rectangle = new RectangleF(Center.X, Center.Y, width, height);
            g.DrawEllipse(p, rectangle);
        }
        public Elipse() : base() { }
        public Elipse(Color color, int Thicknes, Point center, uint width, uint height)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            this.height = height;
            this.width = width;
            this.Center = center;
            p = new Pen(color, Thicknes);
        }
    }
}
