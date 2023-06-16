namespace Programming.View.Controls
{
    partial class SeasonHandleControl
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
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonHandleLabel = new System.Windows.Forms.Label();
            this.SeasonHandleComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonHandleButton = new System.Windows.Forms.Button();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonHandleLabel);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonHandleComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonHandleButton);
            this.SeasonHandleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(0, 0);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(296, 119);
            this.SeasonHandleGroupBox.TabIndex = 10;
            this.SeasonHandleGroupBox.TabStop = false;
            this.SeasonHandleGroupBox.Text = "Season Handle";
            // 
            // SeasonHandleLabel
            // 
            this.SeasonHandleLabel.AutoSize = true;
            this.SeasonHandleLabel.Location = new System.Drawing.Point(6, 50);
            this.SeasonHandleLabel.Name = "SeasonHandleLabel";
            this.SeasonHandleLabel.Size = new System.Drawing.Size(103, 13);
            this.SeasonHandleLabel.TabIndex = 9;
            this.SeasonHandleLabel.Text = "SeasonHandleLabel";
            // 
            // SeasonHandleComboBox
            // 
            this.SeasonHandleComboBox.FormattingEnabled = true;
            this.SeasonHandleComboBox.Location = new System.Drawing.Point(6, 25);
            this.SeasonHandleComboBox.Name = "SeasonHandleComboBox";
            this.SeasonHandleComboBox.Size = new System.Drawing.Size(149, 21);
            this.SeasonHandleComboBox.TabIndex = 8;
            // 
            // SeasonHandleButton
            // 
            this.SeasonHandleButton.Location = new System.Drawing.Point(163, 25);
            this.SeasonHandleButton.Name = "SeasonHandleButton";
            this.SeasonHandleButton.Size = new System.Drawing.Size(75, 23);
            this.SeasonHandleButton.TabIndex = 5;
            this.SeasonHandleButton.Text = "Go!";
            this.SeasonHandleButton.UseVisualStyleBackColor = true;
            this.SeasonHandleButton.Click += new System.EventHandler(this.SeasonHandleButton_Click);
            // 
            // SeasonHandleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SeasonHandleGroupBox);
            this.Name = "SeasonHandleControl";
            this.Size = new System.Drawing.Size(296, 119);
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.Label SeasonHandleLabel;
        private System.Windows.Forms.ComboBox SeasonHandleComboBox;
        private System.Windows.Forms.Button SeasonHandleButton;
    }
}
