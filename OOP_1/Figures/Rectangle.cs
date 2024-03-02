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
        public Point leftUp { get; set; }
        public int width { get; set; }
        public int heigth { get; set; }
        public override void Draw(Graphics g)
        {
            System.Drawing.Rectangle rect = new System.Drawing.Rectangle(leftUp.X, leftUp.Y, width, heigth);
            g.DrawRectangle(p, rect);
        }
        public Rectangle() : base() { }
        public Rectangle(Color color, int Thicknes, Point leftUp, int width, int heigth)
        {
            _PenColor = color;
            _PenThickness = Thicknes;
            this.heigth = heigth;
            this.width = width;
            this.leftUp = leftUp;
            p = new Pen(color, Thicknes);
        }
    }
}
