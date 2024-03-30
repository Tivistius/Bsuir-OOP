using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace OOP_1
{
    public partial class MainForm : Form
    {
        private FigureList list = new FigureList();
        private bool activeCreating;
        private int pointsCounter;
        private int pointsIndex;
        private Figure activeFigure;
        private Point[] points;
        private Color activeColor = Color.Black;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //Line
            Point first = new Point(100, 100);
            Point second = new Point(200, 200);
            Line line = new Line(Color.Blue, 3, first, second);

            //Triangle
            first = new Point(150, 150);
            second = new Point(100, 250);
            Point third = new Point(200, 150);
            Triangle triangle = new Triangle(Color.Green, 2, first, second, third);

            //Rectangle
            Rectangle rectangle = new Rectangle(Color.Black, 5, third, 200, 75);

            //Elipse
            third = new Point(300, 300);
            Elipse elipse = new Elipse(Color.Orange, 2, third, 200, 50);

            //Circle
            Circle circle = new Circle(Color.Azure, 3, third, 100);

            //Squere
            second = new Point(100, 300);
            Square square = new Square(Color.Coral, 5, second, 75);
        }

        private void pDrowSpace_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            list.DrawAll(g);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            panel1.BackColor = colorDialog1.Color;
            activeColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                activeFigure = Activator.CreateInstance(FigureDict.GetFigureType(comboBox1.Text)) as Figure;
                pointsCounter = activeFigure.pointsNumber;
                pointsIndex = 0;
                points = new Point[pointsCounter];
                activeCreating = true;
            }
        }

        private void pDrowSpace_MouseClick(object sender, MouseEventArgs e)
        {
            if (activeCreating)
            {
                if (pointsIndex < pointsCounter)
                {
                    Graphics g = pDrowSpace.CreateGraphics();
                    points[pointsIndex] = e.Location;
                    pointsIndex++;
                    Brush brush = new SolidBrush(activeColor);
                    g.FillEllipse(brush, e.X - 2, e.Y-2, 5, 5);
                    if (pointsIndex == pointsCounter)
                    {
                        activeCreating = false;
                        Type type = activeFigure.GetType();
                        ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(Color), typeof(int), typeof(Point[]) });
                        object[] args = new object[] { activeColor, 3, points };
                        activeFigure = (Figure)constructor.Invoke(args);
                        list.Add(activeFigure);
                        DrawClass.DrawFigure(activeFigure, g);
                        pDrowSpace.Invalidate();
                    }
                }
            }
        }
    }
}
