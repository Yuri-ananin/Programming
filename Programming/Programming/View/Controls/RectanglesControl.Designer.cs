namespace Programming.View.Controls
{
    partial class RectanglesControl
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
            this.RectanglesGroupBox = new System.Windows.Forms.GroupBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.IdRectangleLabel = new System.Windows.Forms.Label();
            this.PointYLabel = new System.Windows.Forms.Label();
            this.PointXLabel = new System.Windows.Forms.Label();
            this.PointXTextBox = new System.Windows.Forms.TextBox();
            this.PointYTextBox = new System.Windows.Forms.TextBox();
            this.FindRectangleWithMaxWidthButton = new System.Windows.Forms.Button();
            this.ColorTextBox = new System.Windows.Forms.TextBox();
            this.WidthTextBox = new System.Windows.Forms.TextBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RectanglesListBox = new System.Windows.Forms.ListBox();
            this.RectanglesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RectanglesGroupBox
            // 
            this.RectanglesGroupBox.Controls.Add(this.IdTextBox);
            this.RectanglesGroupBox.Controls.Add(this.IdRectangleLabel);
            this.RectanglesGroupBox.Controls.Add(this.PointYLabel);
            this.RectanglesGroupBox.Controls.Add(this.PointXLabel);
            this.RectanglesGroupBox.Controls.Add(this.PointXTextBox);
            this.RectanglesGroupBox.Controls.Add(this.PointYTextBox);
            this.RectanglesGroupBox.Controls.Add(this.FindRectangleWithMaxWidthButton);
            this.RectanglesGroupBox.Controls.Add(this.ColorTextBox);
            this.RectanglesGroupBox.Controls.Add(this.WidthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.LengthTextBox);
            this.RectanglesGroupBox.Controls.Add(this.label7);
            this.RectanglesGroupBox.Controls.Add(this.label6);
            this.RectanglesGroupBox.Controls.Add(this.label5);
            this.RectanglesGroupBox.Controls.Add(this.RectanglesListBox);
            this.RectanglesGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RectanglesGroupBox.Location = new System.Drawing.Point(0, 0);
            this.RectanglesGroupBox.Name = "RectanglesGroupBox";
            this.RectanglesGroupBox.Size = new System.Drawing.Size(283, 336);
            this.RectanglesGroupBox.TabIndex = 1;
            this.RectanglesGroupBox.TabStop = false;
            this.RectanglesGroupBox.Text = "Rectangles";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(126, 271);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.ReadOnly = true;
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 15;
            // 
            // IdRectangleLabel
            // 
            this.IdRectangleLabel.AutoSize = true;
            this.IdRectangleLabel.Location = new System.Drawing.Point(126, 255);
            this.IdRectangleLabel.Name = "IdRectangleLabel";
            this.IdRectangleLabel.Size = new System.Drawing.Size(16, 13);
            this.IdRectangleLabel.TabIndex = 14;
            this.IdRectangleLabel.Text = "Id";
            // 
            // PointYLabel
            // 
            this.PointYLabel.AutoSize = true;
            this.PointYLabel.Location = new System.Drawing.Point(123, 216);
            this.PointYLabel.Name = "PointYLabel";
            this.PointYLabel.Size = new System.Drawing.Size(38, 13);
            this.PointYLabel.TabIndex = 13;
            this.PointYLabel.Text = "PointY";
            // 
            // PointXLabel
            // 
            this.PointXLabel.AutoSize = true;
            this.PointXLabel.Location = new System.Drawing.Point(123, 168);
            this.PointXLabel.Name = "PointXLabel";
            this.PointXLabel.Size = new System.Drawing.Size(38, 13);
            this.PointXLabel.TabIndex = 12;
            this.PointXLabel.Text = "PointX";
            // 
            // PointXTextBox
            // 
            this.PointXTextBox.Location = new System.Drawing.Point(126, 184);
            this.PointXTextBox.Multiline = true;
            this.PointXTextBox.Name = "PointXTextBox";
            this.PointXTextBox.ReadOnly = true;
            this.PointXTextBox.Size = new System.Drawing.Size(100, 20);
            this.PointXTextBox.TabIndex = 10;
            // 
            // PointYTextBox
            // 
            this.PointYTextBox.Location = new System.Drawing.Point(126, 232);
            this.PointYTextBox.Name = "PointYTextBox";
            this.PointYTextBox.ReadOnly = true;
            this.PointYTextBox.Size = new System.Drawing.Size(100, 20);
            this.PointYTextBox.TabIndex = 11;
            // 
            // FindRectangleWithMaxWidthButton
            // 
            this.FindRectangleWithMaxWidthButton.Location = new System.Drawing.Point(126, 297);
            this.FindRectangleWithMaxWidthButton.Name = "FindRectangleWithMaxWidthButton";
            this.FindRectangleWithMaxWidthButton.Size = new System.Drawing.Size(100, 23);
            this.FindRectangleWithMaxWidthButton.TabIndex = 8;
            this.FindRectangleWithMaxWidthButton.Text = "Find";
            this.FindRectangleWithMaxWidthButton.UseVisualStyleBackColor = true;
            this.FindRectangleWithMaxWidthButton.Click += new System.EventHandler(this.FindRectangleWithMaxWidthButton_Click);
            // 
            // ColorTextBox
            // 
            this.ColorTextBox.Location = new System.Drawing.Point(126, 135);
            this.ColorTextBox.Name = "ColorTextBox";
            this.ColorTextBox.Size = new System.Drawing.Size(100, 20);
            this.ColorTextBox.TabIndex = 7;
            this.ColorTextBox.TextChanged += new System.EventHandler(this.ColorTextBox_TextChanged);
            // 
            // WidthTextBox
            // 
            this.WidthTextBox.Location = new System.Drawing.Point(126, 84);
            this.WidthTextBox.Name = "WidthTextBox";
            this.WidthTextBox.Size = new System.Drawing.Size(100, 20);
            this.WidthTextBox.TabIndex = 6;
            this.WidthTextBox.TextChanged += new System.EventHandler(this.WidthTextBox_TextChanged);
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Location = new System.Drawing.Point(126, 35);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(100, 20);
            this.LengthTextBox.TabIndex = 5;
            this.LengthTextBox.TextChanged += new System.EventHandler(this.LengthTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(123, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Width:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Length:";
            // 
            // RectanglesListBox
            // 
            this.RectanglesListBox.FormattingEnabled = true;
            this.RectanglesListBox.Items.AddRange(new object[] {
            "Rectangle 1",
            "Rectangle 2",
            "Rectangle 3",
            "Rectangle 4 ",
            "Rectangle 5"});
            this.RectanglesListBox.Location = new System.Drawing.Point(0, 19);
            this.RectanglesListBox.Name = "RectanglesListBox";
            this.RectanglesListBox.Size = new System.Drawing.Size(120, 303);
            this.RectanglesListBox.TabIndex = 1;
            this.RectanglesListBox.SelectedIndexChanged += new System.EventHandler(this.RectanglesListBox_SelectedIndexChanged);
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RectanglesGroupBox);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(283, 336);
            this.RectanglesGroupBox.ResumeLayout(false);
            this.RectanglesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox RectanglesGroupBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.Label IdRectangleLabel;
        private System.Windows.Forms.Label PointYLabel;
        private System.Windows.Forms.Label PointXLabel;
        private System.Windows.Forms.TextBox PointXTextBox;
        private System.Windows.Forms.TextBox PointYTextBox;
        private System.Windows.Forms.Button FindRectangleWithMaxWidthButton;
        private System.Windows.Forms.TextBox ColorTextBox;
        private System.Windows.Forms.TextBox WidthTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox RectanglesListBox;
    }
}
