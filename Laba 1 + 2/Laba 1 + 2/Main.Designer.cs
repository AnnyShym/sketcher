﻿namespace Laba_1___2
{
     partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ellipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectangleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.squareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.rhombusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.widthToolStripMenuItem = new System.Windows.Forms.ToolStripTextBox();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.pbSketchingArea = new System.Windows.Forms.PictureBox();
            this.labelX = new System.Windows.Forms.Label();
            this.labelXValue = new System.Windows.Forms.Label();
            this.labelYValue = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelFigureType = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSketchingArea)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.Window;
            this.menuStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.freeToolStripMenuItem,
            this.lineToolStripMenuItem,
            this.ellipseToolStripMenuItem,
            this.circleToolStripMenuItem,
            this.rectangleToolStripMenuItem,
            this.squareToolStripMenuItem1,
            this.rhombusToolStripMenuItem,
            this.colorToolStripMenuItem,
            this.widthToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(922, 31);
            this.menuStrip.TabIndex = 1;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileToolStripMenuItem.Image")));
            this.fileToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 27);
            this.fileToolStripMenuItem.Text = "File";
            this.fileToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.saveAsToolStripMenuItem.Text = "Save As...";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("quitToolStripMenuItem.Image")));
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem});
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(67, 27);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Enabled = false;
            this.undoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("undoToolStripMenuItem.Image")));
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Enabled = false;
            this.redoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("redoToolStripMenuItem.Image")));
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            // 
            // freeToolStripMenuItem
            // 
            this.freeToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.freeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("freeToolStripMenuItem.Image")));
            this.freeToolStripMenuItem.Margin = new System.Windows.Forms.Padding(180, 0, 0, 0);
            this.freeToolStripMenuItem.Name = "freeToolStripMenuItem";
            this.freeToolStripMenuItem.Size = new System.Drawing.Size(32, 27);
            this.freeToolStripMenuItem.Tag = "free";
            this.freeToolStripMenuItem.Click += new System.EventHandler(this.freeToolStripMenuItem_Click);
            // 
            // lineToolStripMenuItem
            // 
            this.lineToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.lineToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lineToolStripMenuItem.Image")));
            this.lineToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lineToolStripMenuItem.Name = "lineToolStripMenuItem";
            this.lineToolStripMenuItem.Size = new System.Drawing.Size(32, 27);
            this.lineToolStripMenuItem.Tag = "line";
            this.lineToolStripMenuItem.Click += new System.EventHandler(this.lineToolStripMenuItem_Click);
            // 
            // ellipseToolStripMenuItem
            // 
            this.ellipseToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ellipseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ellipseToolStripMenuItem.Image")));
            this.ellipseToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ellipseToolStripMenuItem.Name = "ellipseToolStripMenuItem";
            this.ellipseToolStripMenuItem.Size = new System.Drawing.Size(32, 27);
            this.ellipseToolStripMenuItem.Tag = "ellipse";
            this.ellipseToolStripMenuItem.Click += new System.EventHandler(this.ellipseToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.circleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("circleToolStripMenuItem.Image")));
            this.circleToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(32, 27);
            this.circleToolStripMenuItem.Tag = "circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // rectangleToolStripMenuItem
            // 
            this.rectangleToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rectangleToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rectangleToolStripMenuItem.Image")));
            this.rectangleToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rectangleToolStripMenuItem.Name = "rectangleToolStripMenuItem";
            this.rectangleToolStripMenuItem.Size = new System.Drawing.Size(32, 27);
            this.rectangleToolStripMenuItem.Tag = "rectangle";
            this.rectangleToolStripMenuItem.Click += new System.EventHandler(this.rectangleToolStripMenuItem_Click);
            // 
            // squareToolStripMenuItem1
            // 
            this.squareToolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.squareToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("squareToolStripMenuItem1.Image")));
            this.squareToolStripMenuItem1.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.squareToolStripMenuItem1.Name = "squareToolStripMenuItem1";
            this.squareToolStripMenuItem1.Size = new System.Drawing.Size(32, 27);
            this.squareToolStripMenuItem1.Tag = "square";
            this.squareToolStripMenuItem1.Click += new System.EventHandler(this.squareToolStripMenuItem1_Click);
            // 
            // rhombusToolStripMenuItem
            // 
            this.rhombusToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rhombusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("rhombusToolStripMenuItem.Image")));
            this.rhombusToolStripMenuItem.Margin = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.rhombusToolStripMenuItem.Name = "rhombusToolStripMenuItem";
            this.rhombusToolStripMenuItem.Size = new System.Drawing.Size(32, 27);
            this.rhombusToolStripMenuItem.Tag = "rhombus";
            this.rhombusToolStripMenuItem.Click += new System.EventHandler(this.rhombusToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("colorToolStripMenuItem.Image")));
            this.colorToolStripMenuItem.Margin = new System.Windows.Forms.Padding(230, 0, 0, 0);
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 10, 0);
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(38, 27);
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // widthToolStripMenuItem
            // 
            this.widthToolStripMenuItem.AccessibleDescription = "Line Width";
            this.widthToolStripMenuItem.AutoSize = false;
            this.widthToolStripMenuItem.Name = "widthToolStripMenuItem";
            this.widthToolStripMenuItem.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.widthToolStripMenuItem.Size = new System.Drawing.Size(27, 27);
            this.widthToolStripMenuItem.Text = "2";
            this.widthToolStripMenuItem.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.widthToolStripMenuItem.ToolTipText = "Line Width";
            this.widthToolStripMenuItem.MouseLeave += new System.EventHandler(this.widthToolStripMenuItem_MouseLeave);
            // 
            // colorDialog
            // 
            this.colorDialog.AnyColor = true;
            this.colorDialog.Color = System.Drawing.Color.DarkRed;
            this.colorDialog.FullOpen = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // pbSketchingArea
            // 
            this.pbSketchingArea.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbSketchingArea.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSketchingArea.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pbSketchingArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbSketchingArea.Location = new System.Drawing.Point(0, 31);
            this.pbSketchingArea.Name = "pbSketchingArea";
            this.pbSketchingArea.Size = new System.Drawing.Size(922, 690);
            this.pbSketchingArea.TabIndex = 0;
            this.pbSketchingArea.TabStop = false;
            this.pbSketchingArea.Paint += new System.Windows.Forms.PaintEventHandler(this.pbSketchingArea_Paint);
            this.pbSketchingArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbSketchingArea_MouseDown);
            this.pbSketchingArea.MouseLeave += new System.EventHandler(this.pbSketchingArea_MouseLeave);
            this.pbSketchingArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbSketchingArea_MouseMove);
            this.pbSketchingArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbSketchingArea_MouseUp);
            // 
            // labelX
            // 
            this.labelX.BackColor = System.Drawing.Color.Transparent;
            this.labelX.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelX.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX.Location = new System.Drawing.Point(0, 721);
            this.labelX.Name = "labelX";
            this.labelX.Padding = new System.Windows.Forms.Padding(5, 2, 0, 5);
            this.labelX.Size = new System.Drawing.Size(31, 33);
            this.labelX.TabIndex = 2;
            this.labelX.Text = "x :";
            this.labelX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelXValue
            // 
            this.labelXValue.BackColor = System.Drawing.Color.Transparent;
            this.labelXValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelXValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelXValue.Location = new System.Drawing.Point(31, 721);
            this.labelXValue.Name = "labelXValue";
            this.labelXValue.Size = new System.Drawing.Size(35, 33);
            this.labelXValue.TabIndex = 3;
            this.labelXValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelYValue
            // 
            this.labelYValue.BackColor = System.Drawing.Color.Transparent;
            this.labelYValue.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelYValue.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYValue.Location = new System.Drawing.Point(97, 721);
            this.labelYValue.Name = "labelYValue";
            this.labelYValue.Size = new System.Drawing.Size(35, 33);
            this.labelYValue.TabIndex = 5;
            this.labelYValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelY
            // 
            this.labelY.BackColor = System.Drawing.Color.Transparent;
            this.labelY.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelY.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY.Location = new System.Drawing.Point(66, 721);
            this.labelY.Name = "labelY";
            this.labelY.Padding = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.labelY.Size = new System.Drawing.Size(31, 33);
            this.labelY.TabIndex = 4;
            this.labelY.Text = "y :";
            this.labelY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelColor
            // 
            this.labelColor.BackColor = System.Drawing.Color.Transparent;
            this.labelColor.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelColor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(839, 721);
            this.labelColor.Name = "labelColor";
            this.labelColor.Padding = new System.Windows.Forms.Padding(5, 5, 0, 5);
            this.labelColor.Size = new System.Drawing.Size(83, 33);
            this.labelColor.TabIndex = 6;
            this.labelColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFigureType
            // 
            this.labelFigureType.BackColor = System.Drawing.Color.Transparent;
            this.labelFigureType.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelFigureType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFigureType.Location = new System.Drawing.Point(755, 721);
            this.labelFigureType.Name = "labelFigureType";
            this.labelFigureType.Padding = new System.Windows.Forms.Padding(5, 3, 0, 5);
            this.labelFigureType.Size = new System.Drawing.Size(84, 33);
            this.labelFigureType.TabIndex = 7;
            this.labelFigureType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(922, 754);
            this.Controls.Add(this.labelFigureType);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.labelYValue);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.labelXValue);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.pbSketchingArea);
            this.Controls.Add(this.menuStrip);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sketcher";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbSketchingArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

          }

          #endregion

          private System.Windows.Forms.PictureBox pbSketchingArea;
          private System.Windows.Forms.MenuStrip menuStrip;
          private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem ellipseToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem lineToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem rectangleToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem1;
          private System.Windows.Forms.ToolStripMenuItem rhombusToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem freeToolStripMenuItem;
          private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
          private System.Windows.Forms.ColorDialog colorDialog;
          private System.Windows.Forms.OpenFileDialog openFileDialog;
          private System.Windows.Forms.SaveFileDialog saveFileDialog;
          private System.Windows.Forms.ToolStripTextBox widthToolStripMenuItem;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelXValue;
        private System.Windows.Forms.Label labelYValue;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelFigureType;
    }
}

