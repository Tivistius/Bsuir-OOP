using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_1
{
    public partial class MainForm : Form
    {
        FigureList list;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            list = new FigureList();
            Point first = new Point(100, 100);
            Point second = new Point(200, 200);
            Line line = new Line(Color.Blue, 3, first, second);
            list.Add(line);
            first = new Point(150, 150);
            second = new Point(100, 250);
            Point third = new Point(200, 250);
            Triangle triangle = new Triangle(Color.Green, 2, first, second, third);
            list.Add(triangle);
            Rectangle rectangle = new Rectangle(Color.Black, 5, third, 200, 75);
            list.Add(rectangle);
            third = new Point(300, 300);
            Elipse elipse = new Elipse(Color.Orange, 2, third, 200, 50);
            list.Add(elipse);
            Circle circle = new Circle(Color.Azure, 3, third, 100);
            list.Add(circle);
            second = new Point(100, 300);
            Square square = new Square(Color.Coral, 5, second, 75);
            list.Add(square);
        }

        private void pDrowSpace_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            list.DrawFigures(g);
        }
    }
}
