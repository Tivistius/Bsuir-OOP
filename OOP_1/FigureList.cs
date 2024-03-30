using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    class FigureList
    {
        private List<Figure> _listOfShapes = new List<Figure>();
        public void Add(Figure fig)
        {
            _listOfShapes.Add(fig);
        }

        public void DrawAll(Graphics g)
        {
            foreach (var fig in _listOfShapes)
            {
                DrawClass.DrawFigure(fig,g);
            }
        }
    }
}
