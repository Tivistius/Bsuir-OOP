using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    class Circle : Elipse
    {
        public uint diameter { get; set; }

        public new uint width
        {
            get { return diameter; }
            set { diameter = value; }
        }

        public new uint height
        {
            get { return diameter; }
            set { diameter = value; }
        }
        public Circle() : base() { }
        public Circle(Color color, int thickness, Point center, uint diameter) : base(color, thickness, center, diameter, diameter){ }
    }
}
