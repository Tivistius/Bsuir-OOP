using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    public static class DrawClass
    {
        public static void DrawFigure(Figure figure, Graphics g)
        {
            Brush brush = new SolidBrush(figure.PenColor);
            Pen pen = new Pen(figure.PenColor, figure.PenThicknes);
            if (figure is Elipse)
            {
                g.FillEllipse(brush, (figure as Elipse).center.X - (figure as Elipse).width / 2, (figure as Elipse).center.Y - (figure as Elipse).height / 2, (figure as Elipse).width, (figure as Elipse).height);
            }
            else if (figure is Rectangle)
            {
                g.FillRectangle(brush, (figure as Rectangle).leftUp.X, (figure as Rectangle).leftUp.Y, (figure as Rectangle).width, (figure as Rectangle).height);
            }
            else
            {
                for (int i = 0; i < (figure as Poligon).Points.Length - 1; i++)
                {
                    g.DrawLine(pen, (figure as Poligon).Points[i], (figure as Poligon).Points[i + 1]);
                }
                g.DrawLine(pen, (figure as OOP_1.Poligon).Points[0], (figure as Poligon).Points[(figure as Poligon).Points.Length - 1]);
            }
        }
    }
}
