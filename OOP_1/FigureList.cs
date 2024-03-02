using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{

    //Class that conteins and draw Figures
    class FigureList
    {
        private List<Figure> list;
        private int size;
        public FigureList()
        {
            list = new List<Figure>();
            size = 0;
        }
        public int Size()
        {
            return size;
        }
        public void Add(Figure elem) {
            list.Add(elem);
        }
        public void DrawFigures(Graphics g)
        {
            foreach (Figure figure in list)
            {
                figure.Draw(g);
            }
        }
    }
}
