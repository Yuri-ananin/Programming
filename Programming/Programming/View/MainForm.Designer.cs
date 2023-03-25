namespace Programming
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Enumerations = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EnumsGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ValuesTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayParsingGroupBox = new System.Windows.Forms.GroupBox();
            this.WeekdayParsingLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WeekdayParsingTextBox = new System.Windows.Forms.TextBox();
            this.WeekdayParsingButton = new System.Windows.Forms.Button();
            this.ResultParsingLabel = new System.Windows.Forms.Label();
            this.SeasonHandleGroupBox = new System.Windows.Forms.GroupBox();
            this.SeasonHandleLabel = new System.Windows.Forms.Label();
            this.SeasonHandleComboBox = new System.Windows.Forms.ComboBox();
            this.SeasonHandleButton = new System.Windows.Forms.Button();
            this.Enumerations.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.EnumsGroupBox.SuspendLayout();
            this.WeekdayParsingGroupBox.SuspendLayout();
            this.SeasonHandleGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Enumerations
            // 
            this.Enumerations.Controls.Add(this.tabPage1);
            this.Enumerations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Enumerations.Location = new System.Drawing.Point(0, 0);
            this.Enumerations.Name = "Enumerations";
            this.Enumerations.SelectedIndex = 0;
            this.Enumerations.Size = new System.Drawing.Size(789, 499);
            this.Enumerations.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EnumsGroupBox);
            this.tabPage1.Controls.Add(this.WeekdayParsingGroupBox);
            this.tabPage1.Controls.Add(this.SeasonHandleGroupBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 473);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Enums";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EnumsGroupBox
            // 
            this.EnumsGroupBox.Controls.Add(this.label3);
            this.EnumsGroupBox.Controls.Add(this.label2);
            this.EnumsGroupBox.Controls.Add(this.label1);
            this.EnumsGroupBox.Controls.Add(this.ValuesListBox);
            this.EnumsGroupBox.Controls.Add(this.EnumsListBox);
            this.EnumsGroupBox.Controls.Add(this.ValuesTextBox);
            this.EnumsGroupBox.Location = new System.Drawing.Point(6, 6);
            this.EnumsGroupBox.Name = "EnumsGroupBox";
            this.EnumsGroupBox.Size = new System.Drawing.Size(767, 349);
            this.EnumsGroupBox.TabIndex = 8;
            this.EnumsGroupBox.TabStop = false;
            this.EnumsGroupBox.Text = "Enumerations";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 17);
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
            this.ValuesTextBox.Location = new System.Drawing.Point(371, 33);
            this.ValuesTextBox.Multiline = true;
            this.ValuesTextBox.Name = "ValuesTextBox";
            this.ValuesTextBox.Size = new System.Drawing.Size(142, 25);
            this.ValuesTextBox.TabIndex = 2;
            // 
            // WeekdayParsingGroupBox
            // 
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingLabel);
            this.WeekdayParsingGroupBox.Controls.Add(this.label4);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingTextBox);
            this.WeekdayParsingGroupBox.Controls.Add(this.WeekdayParsingButton);
            this.WeekdayParsingGroupBox.Controls.Add(this.ResultParsingLabel);
            this.WeekdayParsingGroupBox.Location = new System.Drawing.Point(3, 361);
            this.WeekdayParsingGroupBox.Name = "WeekdayParsingGroupBox";
            this.WeekdayParsingGroupBox.Size = new System.Drawing.Size(362, 104);
            this.WeekdayParsingGroupBox.TabIndex = 10;
            this.WeekdayParsingGroupBox.TabStop = false;
            this.WeekdayParsingGroupBox.Text = "Weekday Parsing";
            // 
            // WeekdayParsingLabel
            // 
            this.WeekdayParsingLabel.AutoSize = true;
            this.WeekdayParsingLabel.Location = new System.Drawing.Point(6, 65);
            this.WeekdayParsingLabel.Name = "WeekdayParsingLabel";
            this.WeekdayParsingLabel.Size = new System.Drawing.Size(114, 13);
            this.WeekdayParsingLabel.TabIndex = 9;
            this.WeekdayParsingLabel.Text = "WeekdayParsingLabel";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 8;
            // 
            // WeekdayParsingTextBox
            // 
            this.WeekdayParsingTextBox.Location = new System.Drawing.Point(5, 42);
            this.WeekdayParsingTextBox.Name = "WeekdayParsingTextBox";
            this.WeekdayParsingTextBox.Size = new System.Drawing.Size(213, 20);
            this.WeekdayParsingTextBox.TabIndex = 3;
            // 
            // WeekdayParsingButton
            // 
            this.WeekdayParsingButton.Location = new System.Drawing.Point(224, 42);
            this.WeekdayParsingButton.Name = "WeekdayParsingButton";
            this.WeekdayParsingButton.Size = new System.Drawing.Size(75, 21);
            this.WeekdayParsingButton.TabIndex = 4;
            this.WeekdayParsingButton.Text = "Parse";
            this.WeekdayParsingButton.UseVisualStyleBackColor = true;
            this.WeekdayParsingButton.Click += new System.EventHandler(this.WeekdayParsingButton_Click);
            // 
            // ResultParsingLabel
            // 
            this.ResultParsingLabel.AutoSize = true;
            this.ResultParsingLabel.Location = new System.Drawing.Point(5, 25);
            this.ResultParsingLabel.Name = "ResultParsingLabel";
            this.ResultParsingLabel.Size = new System.Drawing.Size(115, 13);
            this.ResultParsingLabel.TabIndex = 7;
            this.ResultParsingLabel.Text = "Type value for parsing:";
            // 
            // SeasonHandleGroupBox
            // 
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonHandleLabel);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonHandleComboBox);
            this.SeasonHandleGroupBox.Controls.Add(this.SeasonHandleButton);
            this.SeasonHandleGroupBox.Location = new System.Drawing.Point(377, 361);
            this.SeasonHandleGroupBox.Name = "SeasonHandleGroupBox";
            this.SeasonHandleGroupBox.Size = new System.Drawing.Size(396, 106);
            this.SeasonHandleGroupBox.TabIndex = 9;
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
            this.SeasonHandleButton.Location = new System.Drawing.Point(161, 25);
            this.SeasonHandleButton.Name = "SeasonHandleButton";
            this.SeasonHandleButton.Size = new System.Drawing.Size(75, 21);
            this.SeasonHandleButton.TabIndex = 5;
            this.SeasonHandleButton.Text = "Go!";
            this.SeasonHandleButton.UseVisualStyleBackColor = true;
            this.SeasonHandleButton.Click += new System.EventHandler(this.SeasonHandleButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 499);
            this.Controls.Add(this.Enumerations);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Enumerations.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.EnumsGroupBox.ResumeLayout(false);
            this.EnumsGroupBox.PerformLayout();
            this.WeekdayParsingGroupBox.ResumeLayout(false);
            this.WeekdayParsingGroupBox.PerformLayout();
            this.SeasonHandleGroupBox.ResumeLayout(false);
            this.SeasonHandleGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Enumerations;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox ValuesTextBox;
        private System.Windows.Forms.Label ResultParsingLabel;
        private System.Windows.Forms.Button SeasonHandleButton;
        private System.Windows.Forms.TextBox WeekdayParsingTextBox;
        private System.Windows.Forms.ComboBox SeasonHandleComboBox;
        private System.Windows.Forms.GroupBox SeasonHandleGroupBox;
        private System.Windows.Forms.GroupBox WeekdayParsingGroupBox;
        private System.Windows.Forms.GroupBox EnumsGroupBox;
        public System.Windows.Forms.ListBox ValuesListBox;
        public System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label SeasonHandleLabel;
        public System.Windows.Forms.Button WeekdayParsingButton;
        public System.Windows.Forms.Label WeekdayParsingLabel;
    }
}

