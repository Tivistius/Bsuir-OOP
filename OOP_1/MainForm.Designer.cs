﻿
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
        private void InitializeComponent()
        {
            this.pDrowSpace = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pDrowSpace
            // 
            this.pDrowSpace.Location = new System.Drawing.Point(94, 29);
            this.pDrowSpace.Name = "pDrowSpace";
            this.pDrowSpace.Size = new System.Drawing.Size(626, 409);
            this.pDrowSpace.TabIndex = 0;
            this.pDrowSpace.Paint += new System.Windows.Forms.PaintEventHandler(this.pDrowSpace_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pDrowSpace);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pDrowSpace;
    }
}

