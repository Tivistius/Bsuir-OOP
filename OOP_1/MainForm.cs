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

        }

        private void pDrowSpace_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            list.DrawAll(g);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            pnColor.BackColor = colorDialog.Color;
            activeColor = colorDialog.Color;
        }

        private void btnAddFigure_Click(object sender, EventArgs e)
        {
            if (cbListOfFigures.Text != "")
            {
                activeFigure = Activator.CreateInstance(FigureDict.GetFigureType(cbListOfFigures.Text)) as Figure;
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
