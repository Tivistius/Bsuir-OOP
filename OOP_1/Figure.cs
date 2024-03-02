using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace OOP_1
{
    public abstract class Figure
    {
        protected Pen p;
        protected int _PenThickness;
        public int PenThicknes {
            get { return _PenThickness; }
            set
            {
                p = new Pen(_PenColor, value);
                _PenThickness = value;
            }
        }

        protected Color _PenColor;
        public Color PenColor
        {
            get { return _PenColor; }
            set
            {
                p = new Pen(value, _PenThickness);
                _PenColor = value;
            }

        }
        public Figure()
        {
            _PenColor = Color.Black;
            _PenThickness = 1;
            p = new Pen(_PenColor, _PenThickness);
        }
        public abstract void Draw(Graphics g);
    }
}
