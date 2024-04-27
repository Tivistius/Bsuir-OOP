using System.Windows.Forms;
namespace OOP_1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        public class DoubleBufferedPanel : Panel
        {
            public DoubleBufferedPanel()
            {
                DoubleBuffered = true;
            }
        }
        private void InitializeComponent()
        {
            this.pDrowSpace = new OOP_1.MainForm.DoubleBufferedPanel();
            this.cbListOfFigures = new System.Windows.Forms.ComboBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.pnColor = new System.Windows.Forms.Panel();
            this.lbColor = new System.Windows.Forms.Label();
            this.btnChangeColor = new System.Windows.Forms.Button();
            this.btnAddFigure = new System.Windows.Forms.Button();
            this.lbListInd = new System.Windows.Forms.Label();
            this.btnAddToList = new System.Windows.Forms.Button();
            this.openListDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveListDialog = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveToFile = new System.Windows.Forms.Button();
            this.btnLoadFromFile = new System.Windows.Forms.Button();
            this.btnAddPlugin = new System.Windows.Forms.Button();
            this.openDllDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // pDrowSpace
            // 
            this.pDrowSpace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pDrowSpace.Location = new System.Drawing.Point(162, 25);
            this.pDrowSpace.Name = "pDrowSpace";
            this.pDrowSpace.Size = new System.Drawing.Size(626, 409);
            this.pDrowSpace.TabIndex = 0;
            this.pDrowSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.pDrowSpace_Paint);
            this.pDrowSpace.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pDrowSpace_MouseDown);
            this.pDrowSpace.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pDrowSpace_MouseMove);
            this.pDrowSpace.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pDrowSpace_MouseUp);
            // 
            // cbListOfFigures
            // 
            this.cbListOfFigures.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbListOfFigures.FormattingEnabled = true;
            this.cbListOfFigures.Items.AddRange(new object[] {
            "Круг",
            "Квадрат",
            "Прямоугольник",
            "Эллипс",
            "Линия",
            "Треугольник"});
            this.cbListOfFigures.Location = new System.Drawing.Point(12, 25);
            this.cbListOfFigures.Name = "cbListOfFigures";
            this.cbListOfFigures.Size = new System.Drawing.Size(121, 21);
            this.cbListOfFigures.TabIndex = 1;
            // 
            // pnColor
            // 
            this.pnColor.BackColor = System.Drawing.Color.Black;
            this.pnColor.Location = new System.Drawing.Point(97, 100);
            this.pnColor.Name = "pnColor";
            this.pnColor.Size = new System.Drawing.Size(22, 20);
            this.pnColor.TabIndex = 2;
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(14, 104);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(78, 13);
            this.lbColor.TabIndex = 3;
            this.lbColor.Text = "Текущий цвет";
            // 
            // btnChangeColor
            // 
            this.btnChangeColor.Location = new System.Drawing.Point(13, 126);
            this.btnChangeColor.Name = "btnChangeColor";
            this.btnChangeColor.Size = new System.Drawing.Size(120, 23);
            this.btnChangeColor.TabIndex = 4;
            this.btnChangeColor.Text = "Изменить цвет";
            this.btnChangeColor.UseVisualStyleBackColor = true;
            this.btnChangeColor.Click += new System.EventHandler(this.btnChangeColor_Click);
            // 
            // btnAddFigure
            // 
            this.btnAddFigure.Location = new System.Drawing.Point(12, 61);
            this.btnAddFigure.Name = "btnAddFigure";
            this.btnAddFigure.Size = new System.Drawing.Size(121, 23);
            this.btnAddFigure.TabIndex = 5;
            this.btnAddFigure.Text = "Добавить фигуру";
            this.btnAddFigure.UseVisualStyleBackColor = true;
            this.btnAddFigure.Click += new System.EventHandler(this.btnAddFigure_Click);
            // 
            // lbListInd
            // 
            this.lbListInd.AutoSize = true;
            this.lbListInd.Location = new System.Drawing.Point(24, 305);
            this.lbListInd.Name = "lbListInd";
            this.lbListInd.Size = new System.Drawing.Size(35, 13);
            this.lbListInd.TabIndex = 6;
            this.lbListInd.Text = "label1";
            this.lbListInd.Visible = false;
            // 
            // btnAddToList
            // 
            this.btnAddToList.Location = new System.Drawing.Point(17, 267);
            this.btnAddToList.Name = "btnAddToList";
            this.btnAddToList.Size = new System.Drawing.Size(116, 23);
            this.btnAddToList.TabIndex = 7;
            this.btnAddToList.Text = "button1";
            this.btnAddToList.UseVisualStyleBackColor = true;
            this.btnAddToList.Visible = false;
            // 
            // openListDialog
            // 
            this.openListDialog.FileName = "openFileDialog1";
            this.openListDialog.Filter = "Бинарные файлы|*.bin|Xml файлы|*.xml";
            // 
            // saveListDialog
            // 
            this.saveListDialog.DefaultExt = "bin";
            this.saveListDialog.Filter = "Бинарные файлы|*.bin|Xml файлы|*.xml";
            // 
            // btnSaveToFile
            // 
            this.btnSaveToFile.Location = new System.Drawing.Point(12, 411);
            this.btnSaveToFile.Name = "btnSaveToFile";
            this.btnSaveToFile.Size = new System.Drawing.Size(121, 23);
            this.btnSaveToFile.TabIndex = 8;
            this.btnSaveToFile.Text = "Созранить в файл";
            this.btnSaveToFile.UseVisualStyleBackColor = true;
            this.btnSaveToFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadFromFile
            // 
            this.btnLoadFromFile.Location = new System.Drawing.Point(12, 448);
            this.btnLoadFromFile.Name = "btnLoadFromFile";
            this.btnLoadFromFile.Size = new System.Drawing.Size(121, 23);
            this.btnLoadFromFile.TabIndex = 9;
            this.btnLoadFromFile.Text = "Загрузить из файла";
            this.btnLoadFromFile.UseVisualStyleBackColor = true;
            this.btnLoadFromFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddPlugin
            // 
            this.btnAddPlugin.Location = new System.Drawing.Point(690, 448);
            this.btnAddPlugin.Name = "btnAddPlugin";
            this.btnAddPlugin.Size = new System.Drawing.Size(98, 23);
            this.btnAddPlugin.TabIndex = 10;
            this.btnAddPlugin.Text = "Загрузить dll";
            this.btnAddPlugin.UseVisualStyleBackColor = true;
            this.btnAddPlugin.Click += new System.EventHandler(this.btnAddPlugin_Click);
            // 
            // openDllDialog
            // 
            this.openDllDialog.FileName = "openFileDialog1";
            this.openDllDialog.Filter = "Файлы dll|*.dll";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 499);
            this.Controls.Add(this.btnAddPlugin);
            this.Controls.Add(this.btnLoadFromFile);
            this.Controls.Add(this.btnSaveToFile);
            this.Controls.Add(this.btnAddToList);
            this.Controls.Add(this.lbListInd);
            this.Controls.Add(this.btnAddFigure);
            this.Controls.Add(this.btnChangeColor);
            this.Controls.Add(this.lbColor);
            this.Controls.Add(this.pnColor);
            this.Controls.Add(this.cbListOfFigures);
            this.Controls.Add(this.pDrowSpace);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbListOfFigures;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.Panel pnColor;
        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.Button btnChangeColor;
        private System.Windows.Forms.Button btnAddFigure;
        private System.Windows.Forms.Label lbListInd;
        private System.Windows.Forms.Button btnAddToList;
        private DoubleBufferedPanel pDrowSpace;
        private OpenFileDialog openListDialog;
        private SaveFileDialog saveListDialog;
        private Button btnSaveToFile;
        private Button btnLoadFromFile;
        private Button btnAddPlugin;
        private OpenFileDialog openDllDialog;
    }
}

