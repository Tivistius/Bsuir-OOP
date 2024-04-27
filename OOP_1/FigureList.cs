using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    [Serializable]
    public class FigureList
    {
        public List<Figure> _listOfFigures = new List<Figure>();

        public void Add(Figure fig)
        {
            _listOfFigures.Add(fig);
        }

        public void DrawAll(Graphics g)
        {
            foreach (var fig in _listOfFigures)
            {
                DrawClass.DrawFigure(fig, g);
            }
        }
        public bool Contains(Figure fig)
        {
            return _listOfFigures.Contains(fig);
        }
        public bool Remove(Figure fig)
        {
            return _listOfFigures.Remove(fig);
        }
        public IEnumerator<Figure> GetEnumerator()
        {
            return _listOfFigures.GetEnumerator();
        }
    }
}
