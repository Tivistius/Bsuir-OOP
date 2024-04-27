using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Xml.Serialization;
namespace OOP_1
{
    [Serializable]
    public abstract class Figure
    {
        public static string name { get => "Фигура"; }
        public abstract int PointsNumber { get; }
        public PointF[] _Points;
        public abstract PointF[] Points { get; }
        protected int _PenThickness;
        public int PenThicknes
        {
            get { return _PenThickness; }
            set
            {
                _PenThickness = value;
            }
        }
        protected Color _PenColor;
        public string PenColorAsString
        {   
            get { return ColorTranslator.ToHtml(_PenColor); }
            set
            {
                _PenColor = ColorTranslator.FromHtml(value);
            }
        }
        [XmlIgnore]
        public Color PenColor
        {
            get { return _PenColor; }
            set { _PenColor = value; }
        }
        public abstract bool IsPointFInFigure(PointF PointF);
        public abstract void ChangeState(PointF[] Points);
        public Figure()
        {
            _PenColor = Color.Black;
            _PenThickness = 1;
        }
        public Figure(Color color, int Thicknes, PointF[] Points){ }
    }
}
