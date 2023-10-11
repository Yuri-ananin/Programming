namespace Programming.View.Controls
{
    partial class FilmsControl
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
            this.FilmsGroupBox = new System.Windows.Forms.GroupBox();
            this.RatingLabel = new System.Windows.Forms.Label();
            this.GenreLabel = new System.Windows.Forms.Label();
            this.YearLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.FindFilmWithMaxRatingButton = new System.Windows.Forms.Button();
            this.DurationTextBox = new System.Windows.Forms.TextBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.GenreTextBox = new System.Windows.Forms.TextBox();
            this.RatingTextBox = new System.Windows.Forms.TextBox();
            this.FilmsListBox = new System.Windows.Forms.ListBox();
            this.FilmsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // FilmsGroupBox
            // 
            this.FilmsGroupBox.Controls.Add(this.RatingLabel);
            this.FilmsGroupBox.Controls.Add(this.GenreLabel);
            this.FilmsGroupBox.Controls.Add(this.YearLabel);
            this.FilmsGroupBox.Controls.Add(this.DurationLabel);
            this.FilmsGroupBox.Controls.Add(this.FindFilmWithMaxRatingButton);
            this.FilmsGroupBox.Controls.Add(this.DurationTextBox);
            this.FilmsGroupBox.Controls.Add(this.YearTextBox);
            this.FilmsGroupBox.Controls.Add(this.GenreTextBox);
            this.FilmsGroupBox.Controls.Add(this.RatingTextBox);
            this.FilmsGroupBox.Controls.Add(this.FilmsListBox);
            this.FilmsGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilmsGroupBox.Location = new System.Drawing.Point(0, 0);
            this.FilmsGroupBox.Name = "FilmsGroupBox";
            this.FilmsGroupBox.Size = new System.Drawing.Size(293, 335);
            this.FilmsGroupBox.TabIndex = 10;
            this.FilmsGroupBox.TabStop = false;
            this.FilmsGroupBox.Text = "Films";
            // 
            // RatingLabel
            // 
            this.RatingLabel.AutoSize = true;
            this.RatingLabel.Location = new System.Drawing.Point(174, 168);
            this.RatingLabel.Name = "RatingLabel";
            this.RatingLabel.Size = new System.Drawing.Size(41, 13);
            this.RatingLabel.TabIndex = 17;
            this.RatingLabel.Text = "Rating:";
            // 
            // GenreLabel
            // 
            this.GenreLabel.AutoSize = true;
            this.GenreLabel.Location = new System.Drawing.Point(174, 117);
            this.GenreLabel.Name = "GenreLabel";
            this.GenreLabel.Size = new System.Drawing.Size(39, 13);
            this.GenreLabel.TabIndex = 16;
            this.GenreLabel.Text = "Genre:";
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Location = new System.Drawing.Point(174, 68);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(32, 13);
            this.YearLabel.TabIndex = 15;
            this.YearLabel.Text = "Year:";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(174, 19);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(50, 13);
            this.DurationLabel.TabIndex = 14;
            this.DurationLabel.Text = "Duration:";
            // 
            // FindFilmWithMaxRatingButton
            // 
            this.FindFilmWithMaxRatingButton.Location = new System.Drawing.Point(174, 297);
            this.FindFilmWithMaxRatingButton.Name = "FindFilmWithMaxRatingButton";
            this.FindFilmWithMaxRatingButton.Size = new System.Drawing.Size(100, 23);
            this.FindFilmWithMaxRatingButton.TabIndex = 13;
            this.FindFilmWithMaxRatingButton.Text = "Find";
            this.FindFilmWithMaxRatingButton.UseVisualStyleBackColor = true;
            this.FindFilmWithMaxRatingButton.Click += new System.EventHandler(this.FindFilmWithMaxRatingButton_Click);
            // 
            // DurationTextBox
            // 
            this.DurationTextBox.Location = new System.Drawing.Point(174, 35);
            this.DurationTextBox.Name = "DurationTextBox";
            this.DurationTextBox.Size = new System.Drawing.Size(100, 20);
            this.DurationTextBox.TabIndex = 9;
            this.DurationTextBox.TextChanged += new System.EventHandler(this.DurationTextBox_TextChanged);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Location = new System.Drawing.Point(174, 84);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(100, 20);
            this.YearTextBox.TabIndex = 10;
            this.YearTextBox.TextChanged += new System.EventHandler(this.YearTextBox_TextChanged);
            // 
            // GenreTextBox
            // 
            this.GenreTextBox.Location = new System.Drawing.Point(174, 135);
            this.GenreTextBox.Name = "GenreTextBox";
            this.GenreTextBox.Size = new System.Drawing.Size(100, 20);
            this.GenreTextBox.TabIndex = 11;
            this.GenreTextBox.TextChanged += new System.EventHandler(this.GenreTextBox_TextChanged);
            // 
            // RatingTextBox
            // 
            this.RatingTextBox.Location = new System.Drawing.Point(174, 184);
            this.RatingTextBox.Name = "RatingTextBox";
            this.RatingTextBox.Size = new System.Drawing.Size(100, 20);
            this.RatingTextBox.TabIndex = 12;
            this.RatingTextBox.TextChanged += new System.EventHandler(this.RatingTextBox_TextChanged);
            // 
            // FilmsListBox
            // 
            this.FilmsListBox.FormattingEnabled = true;
            this.FilmsListBox.Location = new System.Drawing.Point(0, 17);
            this.FilmsListBox.Name = "FilmsListBox";
            this.FilmsListBox.Size = new System.Drawing.Size(168, 303);
            this.FilmsListBox.TabIndex = 0;
            this.FilmsListBox.SelectedIndexChanged += new System.EventHandler(this.FilmsListBox_SelectedIndexChanged);
            // 
            // FilmsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FilmsGroupBox);
            this.Name = "FilmsControl";
            this.Size = new System.Drawing.Size(293, 335);
            this.FilmsGroupBox.ResumeLayout(false);
            this.FilmsGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox FilmsGroupBox;
        private System.Windows.Forms.Label RatingLabel;
        private System.Windows.Forms.Label GenreLabel;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Button FindFilmWithMaxRatingButton;
        private System.Windows.Forms.TextBox DurationTextBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox GenreTextBox;
        private System.Windows.Forms.TextBox RatingTextBox;
        private System.Windows.Forms.ListBox FilmsListBox;
    }
}
