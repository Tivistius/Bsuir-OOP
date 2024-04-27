using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Reflection;

namespace OOP_1
{
    public static class DrawClass
    {
        public static void DrawFigure(Figure figure, Graphics g)
        {
            string className = figure.GetType().Name;
            string fullName = figure.GetType().AssemblyQualifiedName;
            fullName = fullName.Replace(className, "DrawClass");
            MethodInfo method = Type.GetType(fullName).GetMethod(className, BindingFlags.NonPublic | BindingFlags.Static);
            if (method == null)
            {
                throw new NullReferenceException();
            }
            method.Invoke(null, new object[] { figure, g });
        }
        private static void Rectangle(Rectangle rect, Graphics g)
        {
            Brush brush = new SolidBrush(rect.PenColor);
            g.FillRectangle(brush, rect.leftUp.X, rect.leftUp.Y, rect.width, rect.height);
        }
        private static void Circle(Circle circle, Graphics g)
        {
            Brush brush = new SolidBrush(circle.PenColor);
            g.FillEllipse(brush, circle.center.X - circle.width / 2, circle.center.Y - circle.height / 2, circle.width, circle.height);
        }
        private static void Poligon(Poligon poligon, Graphics g)
        {
            Brush brush = new SolidBrush(poligon.PenColor);
            g.FillPolygon(brush, poligon.Points);
        }
        private static void Triangle(Triangle triag, Graphics g)
        {
            Brush brush = new SolidBrush(triag.PenColor);
            g.FillPolygon(brush, triag.Points);
        }
        private static void Elipse(Elipse el, Graphics g)
        {
            Brush brush = new SolidBrush(el.PenColor);
            g.FillEllipse(brush, el.center.X - el.width / 2, el.center.Y - el.height / 2, el.width, el.height);
        }
        private static void Line(Line line, Graphics g)
        {
            Brush brush = new SolidBrush(line.PenColor);
            g.FillPolygon(brush, line.Points);
        }
        private static void Square(Square square, Graphics g)
        {
            Brush brush = new SolidBrush(square.PenColor);
            g.FillRectangle(brush, square.leftUp.X, square.leftUp.Y, square.width, square.height);
        }
    }
}
