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
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace OOP_1
{
    public partial class MainForm : Form
    {
        private FigureList list = new FigureList();
        private FigureList listTest = new FigureList();
        private Color tempFigColor;
        private PointF clickPointF; 
        private bool IsDragging = false;
        private EventHandler btnAddToListFunc;
        private List<Type> figureTypes = new List<Type>();
        private bool activeCreating;
        private int PointsCounter;
        private int PointsIndex;
        private Figure activeFigure = null;
        private PointF[] Points;
        private Color activeColor = Color.Black;
        public MainForm()
        {
            InitializeComponent();
        }
        public void loadFigure(string path)
        {
            Assembly assembly = Assembly.LoadFrom(path);
            Type[] types = assembly.GetTypes();
            foreach(var type in types)
            {
                Assembly.CreateQualifiedName(type.AssemblyQualifiedName, type.Name);
            }
            List<Type> tempList = types.Where(t => t.IsSubclassOf(typeof(Figure))).ToList();
            foreach (var type in tempList)
            {
                if (!type.IsAbstract)
                {
                    figureTypes.Add(type);
                    cbListOfFigures.Items.Add((string)type.GetProperty("name").GetValue(null));
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            Type[] types = assembly.GetTypes();

            List<Type> tempList = types.Where(t => t.IsSubclassOf(typeof(Figure))).ToList();
            foreach(var type in tempList)
            {
                if (!type.IsAbstract)
                {
                    figureTypes.Add(type);
                }
            }
            string[] names = new string[figureTypes.Count];
            for (int i = 0; i< figureTypes.Count;i++)
            {
                PropertyInfo property = figureTypes[i].GetProperty("name");
                names[i] = (string)property.GetValue(null);
            }
            cbListOfFigures.Items.Clear();
            cbListOfFigures.Items.AddRange(names);
        }

        private void pDrowSpace_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            list.DrawAll(g);
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

                foreach(var fig in figureTypes)
                {
                    PropertyInfo property = fig.GetProperty("name");
                    if ((string)property.GetValue(null) == cbListOfFigures.Text)
                    {
                        activeFigure = Activator.CreateInstance(fig) as Figure;
                        break;
                    }
                }
                PointsCounter = activeFigure.PointsNumber;
                PointsIndex = 0;
                Points = new PointF[PointsCounter];
                activeCreating = true;
            }
        }

        private void pDrowSpace_MouseDown(object sender, MouseEventArgs e)
        {
            if (activeCreating)
            {
                if (PointsIndex < PointsCounter)
                {
                    Graphics g = pDrowSpace.CreateGraphics();
                    Points[PointsIndex] = e.Location;
                    PointsIndex++;
                    Brush brush = new SolidBrush(activeColor);
                    g.FillEllipse(brush, e.X - 2, e.Y-2, 5, 5);
                    if (PointsIndex == PointsCounter)
                    {
                        activeCreating = false;
                        Type type = activeFigure.GetType();
                        ConstructorInfo constructor = type.GetConstructor(new Type[] { typeof(Color), typeof(int), typeof(PointF[]) });
                        object[] args = new object[] { activeColor, 3, Points };
                        activeFigure = (Figure)constructor.Invoke(args);
                        list.Add(activeFigure);
                        listTest.Add(activeFigure);
                        DrawClass.DrawFigure(activeFigure, g);
                        pDrowSpace.Invalidate();
                        activeFigure = null;
                    }
                }
            }
            else
            {
                foreach(Figure fig in list)
                {
                    if (fig.IsPointFInFigure(e.Location))
                    {
                        if (activeFigure != fig)
                        {
                            CancelSelection(activeFigure);
                        }
                        activeFigure = fig;
                        if (fig.PenColor != Color.Cyan)
                        {
                            tempFigColor = fig.PenColor;
                        }
                        fig.PenColor = Color.Cyan;
                        lbListInd.Show();
                        btnAddToList.Show();
                        Action addToList = null;
                        Action removeFromList = () =>
                        {
                            btnAddToList.Click -= btnAddToListFunc;
                            btnAddToList.Text = "Удалить из списка";
                            lbListInd.Text = "Есть в списке";
                            btnAddToList.Click += btnAddToListFunc = (senderr, ee) =>
                            {
                                listTest.Remove(fig);
                                addToList();
                            };
                        };
                        addToList = () =>
                        {
                            btnAddToList.Click -= btnAddToListFunc;
                            btnAddToList.Text = "Добавить в список";
                            lbListInd.Text = "Нет в списке";
                            btnAddToList.Click += btnAddToListFunc = (senderr, ee) =>
                            {
                                listTest.Add(fig);
                                removeFromList();
                            };
                        };
                        if (listTest.Contains(fig))
                        {
                            removeFromList();
                        }
                        else
                        {
                            addToList();
                        }
                        clickPointF = e.Location;
                        IsDragging = true;
                        pDrowSpace.Invalidate();
                        return;
                    }
                }
                CancelSelection(activeFigure);
                pDrowSpace.Invalidate();
            }
        }

        private void CancelSelection(Figure activeFigure)
        {
            if (activeFigure != null)
            {
                activeFigure.PenColor = tempFigColor;
                activeFigure = null;
                lbListInd.Hide();
                btnAddToList.Hide();
            }
        }
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void pDrowSpace_MouseMove(object sender, MouseEventArgs e)
        {
            if (IsDragging)
            {
                float offsetX = e.Location.X - clickPointF.X;
                float offsetY = e.Location.Y - clickPointF.Y;
                clickPointF.X = e.Location.X;
                clickPointF.Y = e.Location.Y;

                PointF[] tempPoints = new PointF[activeFigure.PointsNumber];
                for (int i = 0; i < activeFigure.PointsNumber; i++)
                {
                    tempPoints[i] = new PointF(activeFigure.Points[i].X + offsetX, activeFigure.Points[i].Y + offsetY);
                }
                activeFigure.ChangeState(tempPoints);
                pDrowSpace.Invalidate();
            }
        }

        private void pDrowSpace_MouseUp(object sender, MouseEventArgs e)
        {
            IsDragging = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveListDialog.FileName = "";
            saveListDialog.ShowDialog();
            if (saveListDialog.FileName != "")
            {
                if (Path.GetExtension(saveListDialog.FileName) == ".bin")
                {
                    using (FileStream fs = new FileStream(saveListDialog.FileName, FileMode.Create))
                    {
                        BinaryFormatter serializer = new BinaryFormatter();
                        serializer.Serialize(fs, listTest);
                    }
                }
                else if (Path.GetExtension(saveListDialog.FileName) == ".xml")
                {
                    using (FileStream fs = new FileStream(saveListDialog.FileName, FileMode.Create))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(FigureList), figureTypes.ToArray());
                        serializer.Serialize(fs, listTest);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openListDialog.FileName = "";
            openListDialog.ShowDialog();
            if (openListDialog.FileName != "")
            {
                if (Path.GetExtension(openListDialog.FileName) == ".bin")
                {
                    using (FileStream fs = new FileStream(openListDialog.FileName, FileMode.Open))
                    {
                        BinaryFormatter serializer = new BinaryFormatter();
                        list = (FigureList)serializer.Deserialize(fs);
                        listTest = list;
                    }
                }
                else if (Path.GetExtension(openListDialog.FileName) == ".xml")
                {
                    using (FileStream fs = new FileStream(openListDialog.FileName, FileMode.Open))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(FigureList), figureTypes.ToArray());
                        list = (FigureList)serializer.Deserialize(fs);
                        listTest = list;
                    }
                }
                else
                {
                    MessageBox.Show("Unsuported extention");
                }
                pDrowSpace.Invalidate();
            }
        }

        private void btnAddPlugin_Click(object sender, EventArgs e)
        {
            openDllDialog.FileName = "";
            openDllDialog.ShowDialog();
            if (openDllDialog.FileName != "")
            {
                loadFigure(openDllDialog.FileName);
            }
        }
    }
}
