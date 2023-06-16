namespace Programming.View.Controls
{
    partial class EnumsControl
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
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesTextBox = new System.Windows.Forms.TextBox();
            this.EnumsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnumsGroupBox
            // 
            this.EnumsGroupBox.Controls.Add(this.label3);
            this.EnumsGroupBox.Controls.Add(this.label2);
            this.EnumsGroupBox.Controls.Add(this.label1);
            this.EnumsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumsGroupBox.Controls.Add(this.ValuesTextBox);
            this.EnumsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EnumsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Size = new System.Drawing.Size(576, 359);
            this.EnumsGroupBox.TabIndex = 9;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "int value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose value:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(201, 33);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(158, 316);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Location = new System.Drawing.Point(15, 33);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(159, 316);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.EnumsListBox_SelectedIndexChanged);
            // 
            // ValuesTextBox
            // 
            this.ValuesTextBox.Location = new System.Drawing.Point(383, 33);
            this.ValuesTextBox.Multiline = true;
            this.ValuesTextBox.Name = "ValuesTextBox";
            this.ValuesTextBox.Size = new System.Drawing.Size(142, 25);
            this.ValuesTextBox.TabIndex = 2;
            // 
            // EnumsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EnumsGroupBox);
            this.Name = "EnumsControl";
            this.Size = new System.Drawing.Size(576, 359);
            this.EnumsGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EnumsGroupBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ListBox ValuesListBox;
        public System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.TextBox ValuesTextBox;
    }
}
