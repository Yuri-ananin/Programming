namespace Programming.View.Controls
{
    partial class RectanglesCollisionControl
    {
        /// <summary> 
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.IdRectangleTextBox = new System.Windows.Forms.TextBox();
            this.XRectangleTextBox = new System.Windows.Forms.TextBox();
            this.YRectangleTextBox = new System.Windows.Forms.TextBox();
            this.WidthRectangleTextBox = new System.Windows.Forms.TextBox();
            this.HeightRectangleTextBox = new System.Windows.Forms.TextBox();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WidthLabel = new System.Windows.Forms.Label();
            this.YLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.IdLabel = new System.Windows.Forms.Label();
            this.SelectedRectangleLabel = new System.Windows.Forms.Label();
            this.RectanglesLabel = new System.Windows.Forms.Label();
            this.PanelRectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesPanel = new System.Windows.Forms.Panel();
            this.RemoveRectangleButton = new System.Windows.Forms.Button();
            this.AddRectangleButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.IdRectangleTextBox);
            this.panel1.Controls.Add(this.XRectangleTextBox);
            this.panel1.Controls.Add(this.YRectangleTextBox);
            this.panel1.Controls.Add(this.WidthRectangleTextBox);
            this.panel1.Controls.Add(this.HeightRectangleTextBox);
            this.panel1.Controls.Add(this.HeightLabel);
            this.panel1.Controls.Add(this.WidthLabel);
            this.panel1.Controls.Add(this.YLabel);
            this.panel1.Controls.Add(this.XLabel);
            this.panel1.Controls.Add(this.IdLabel);
            this.panel1.Controls.Add(this.SelectedRectangleLabel);
            this.panel1.Controls.Add(this.RectanglesLabel);
            this.panel1.Controls.Add(this.PanelRectanglesListBox);
            this.panel1.Controls.Add(this.RectanglesPanel);
            this.panel1.Controls.Add(this.RemoveRectangleButton);
            this.panel1.Controls.Add(this.AddRectangleButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(586, 487);
            this.panel1.TabIndex = 0;
            // 
            // IdRectangleTextBox
            // 
            this.IdRectangleTextBox.Location = new System.Drawing.Point(48, 226);
            this.IdRectangleTextBox.Name = "IdRectangleTextBox";
            this.IdRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdRectangleTextBox.TabIndex = 31;
            // 
            // XRectangleTextBox
            // 
            this.XRectangleTextBox.Location = new System.Drawing.Point(48, 256);
            this.XRectangleTextBox.Name = "XRectangleTextBox";
            this.XRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.XRectangleTextBox.TabIndex = 30;
            this.XRectangleTextBox.TextChanged += new System.EventHandler(this.XRectangleTextBox_TextChanged);
            // 
            // YRectangleTextBox
            // 
            this.YRectangleTextBox.Location = new System.Drawing.Point(48, 282);
            this.YRectangleTextBox.Name = "YRectangleTextBox";
            this.YRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.YRectangleTextBox.TabIndex = 29;
            this.YRectangleTextBox.TextChanged += new System.EventHandler(this.YRectangleTextBox_TextChanged);
            // 
            // WidthRectangleTextBox
            // 
            this.WidthRectangleTextBox.Location = new System.Drawing.Point(48, 308);
            this.WidthRectangleTextBox.Name = "WidthRectangleTextBox";
            this.WidthRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthRectangleTextBox.TabIndex = 28;
            this.WidthRectangleTextBox.TextChanged += new System.EventHandler(this.WidthRectangleTextBox_TextChanged);
            // 
            // HeightRectangleTextBox
            // 
            this.HeightRectangleTextBox.Location = new System.Drawing.Point(48, 334);
            this.HeightRectangleTextBox.Name = "HeightRectangleTextBox";
            this.HeightRectangleTextBox.Size = new System.Drawing.Size(100, 20);
            this.HeightRectangleTextBox.TabIndex = 27;
            this.HeightRectangleTextBox.TextChanged += new System.EventHandler(this.HeightRectangleTextBox_TextChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.AutoSize = true;
            this.HeightLabel.Location = new System.Drawing.Point(5, 337);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(41, 13);
            this.HeightLabel.TabIndex = 26;
            this.HeightLabel.Text = "Height:";
            // 
            // WidthLabel
            // 
            this.WidthLabel.AutoSize = true;
            this.WidthLabel.Location = new System.Drawing.Point(8, 311);
            this.WidthLabel.Name = "WidthLabel";
            this.WidthLabel.Size = new System.Drawing.Size(38, 13);
            this.WidthLabel.TabIndex = 25;
            this.WidthLabel.Text = "Width:";
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(29, 285);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(17, 13);
            this.YLabel.TabIndex = 24;
            this.YLabel.Text = "Y:";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(29, 259);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 13);
            this.XLabel.TabIndex = 23;
            this.XLabel.Text = "X:";
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(29, 233);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 22;
            this.IdLabel.Text = "Id:";
            // 
            // SelectedRectangleLabel
            // 
            this.SelectedRectangleLabel.AutoSize = true;
            this.SelectedRectangleLabel.Location = new System.Drawing.Point(2, 210);
            this.SelectedRectangleLabel.Name = "SelectedRectangleLabel";
            this.SelectedRectangleLabel.Size = new System.Drawing.Size(104, 13);
            this.SelectedRectangleLabel.TabIndex = 21;
            this.SelectedRectangleLabel.Text = "Selected Rectangle:";
            // 
            // RectanglesLabel
            // 
            this.RectanglesLabel.AutoSize = true;
            this.RectanglesLabel.Location = new System.Drawing.Point(8, 3);
            this.RectanglesLabel.Name = "RectanglesLabel";
            this.RectanglesLabel.Size = new System.Drawing.Size(64, 13);
            this.RectanglesLabel.TabIndex = 20;
            this.RectanglesLabel.Text = "Rectangles:";
            // 
            // PanelRectanglesListBox
            // 
            this.PanelRectanglesListBox.FormattingEnabled = true;
            this.PanelRectanglesListBox.Location = new System.Drawing.Point(2, 18);
            this.PanelRectanglesListBox.Name = "PanelRectanglesListBox";
            this.PanelRectanglesListBox.Size = new System.Drawing.Size(216, 147);
            this.PanelRectanglesListBox.TabIndex = 19;
            this.PanelRectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.PanelRectanglesListBox_SelectedIndexChanged);
            this.PanelRectanglesListBox.TabIndexChanged += new System.EventHandler(this.PanelRectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesPanel
            // 
            this.RectanglesPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RectanglesPanel.Location = new System.Drawing.Point(220, 3);
            this.RectanglesPanel.Name = "RectanglesPanel";
            this.RectanglesPanel.Size = new System.Drawing.Size(349, 467);
            this.RectanglesPanel.TabIndex = 18;
            // 
            // RemoveRectangleButton
            // 
            this.RemoveRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRectangleButton.Location = new System.Drawing.Point(112, 171);
            this.RemoveRectangleButton.Name = "RemoveRectangleButton";
            this.RemoveRectangleButton.Size = new System.Drawing.Size(106, 23);
            this.RemoveRectangleButton.TabIndex = 17;
            this.RemoveRectangleButton.Text = "remove rectangle";
            this.RemoveRectangleButton.UseVisualStyleBackColor = true;
            this.RemoveRectangleButton.Click += new System.EventHandler(this.RemoveRectangleButton_Click);
            // 
            // AddRectangleButton
            // 
            this.AddRectangleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRectangleButton.Location = new System.Drawing.Point(2, 171);
            this.AddRectangleButton.Name = "AddRectangleButton";
            this.AddRectangleButton.Size = new System.Drawing.Size(104, 23);
            this.AddRectangleButton.TabIndex = 16;
            this.AddRectangleButton.Text = "add rectangle";
            this.AddRectangleButton.UseVisualStyleBackColor = true;
            this.AddRectangleButton.Click += new System.EventHandler(this.AddRectangleButton_Click);
            // 
            // RectanglesCollisionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "RectanglesCollisionControl";
            this.Size = new System.Drawing.Size(586, 487);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox IdRectangleTextBox;
        private System.Windows.Forms.TextBox XRectangleTextBox;
        private System.Windows.Forms.TextBox YRectangleTextBox;
        private System.Windows.Forms.TextBox WidthRectangleTextBox;
        private System.Windows.Forms.TextBox HeightRectangleTextBox;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WidthLabel;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label SelectedRectangleLabel;
        private System.Windows.Forms.Label RectanglesLabel;
        private System.Windows.Forms.ListBox PanelRectanglesListBox;
        private System.Windows.Forms.Panel RectanglesPanel;
        private System.Windows.Forms.Button RemoveRectangleButton;
        private System.Windows.Forms.Button AddRectangleButton;



    }
}
