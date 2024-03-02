using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_1
{
    class Square : Rectangle
    {
        public int size { get; set; }
        public new int width
        {
            get { return size; }
            set { size = value; }
        }

        public new int height
        {
            get { return size; }
            set { size = value; }
        }
        public Square() : base() { }
        public Square(Color color, int thickness, Point center, int size) : base(color, thickness, center, size, size){ }
    }
}
