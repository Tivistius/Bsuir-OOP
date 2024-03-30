using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    static class FigureDict
    {
        private static Dictionary<string, string> StringsShapes = new Dictionary<string, string>
        {
            { "квадрат", "Square" },
            { "прямоугольник","Rectangle"},
            { "круг","Circle"},
            { "эллипс","Elipse"},
            { "треугольник","Triangle"},
            { "линия", "Line"},
        };
        public static Type GetFigureType(string type) 
        {
            StringsShapes.TryGetValue(type.ToLower(),out var res);
            return Type.GetType("OOP_1."+res);
        }
    }
}
