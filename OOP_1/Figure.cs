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
        public abstract int pointsNumber { get; }
        protected int _PenThickness;
        public int PenThicknes {
            get { return _PenThickness; }
            set
            {
                _PenThickness = value;
            }
        }

        protected Color _PenColor;
        public Color PenColor
        {
            get { return _PenColor; }
            set
            {
                _PenColor = value;
            }

        }
        public abstract void ChangeState(Point[] points);
        public Figure()
        {
            _PenColor = Color.Black;
            _PenThickness = 1;
        }
        public Figure(Color color, int Thicknes, Point[] points){ }
    }
}
