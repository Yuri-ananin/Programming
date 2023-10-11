namespace SongsListApp
{
    partial class SongsControl
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            SongsListBox = new ListBox();
            SelectedSongGroupBox = new GroupBox();
            ApplyButton = new Button();
            GenreLabel = new Label();
            GenreComboBox = new ComboBox();
            DurationLabel = new Label();
            DurationTextBox = new TextBox();
            PerformerNameTextBox = new TextBox();
            PerformerNameLabel = new Label();
            SongNameLabel = new Label();
            SongNameTextBox = new TextBox();
            AddButton = new Button();
            DeleteButton = new Button();
            EditButton = new Button();
            SelectedSongGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SongsListBox
            // 
            SongsListBox.FormattingEnabled = true;
            SongsListBox.ItemHeight = 15;
            SongsListBox.Location = new Point(3, 3);
            SongsListBox.Name = "SongsListBox";
            SongsListBox.Size = new Size(232, 394);
            SongsListBox.TabIndex = 0;
            SongsListBox.SelectedIndexChanged += SongsListBox_SelectedIndexChanged;
            // 
            // SelectedSongGroupBox
            // 
            SelectedSongGroupBox.Controls.Add(ApplyButton);
            SelectedSongGroupBox.Controls.Add(GenreLabel);
            SelectedSongGroupBox.Controls.Add(GenreComboBox);
            SelectedSongGroupBox.Controls.Add(DurationLabel);
            SelectedSongGroupBox.Controls.Add(DurationTextBox);
            SelectedSongGroupBox.Controls.Add(PerformerNameTextBox);
            SelectedSongGroupBox.Controls.Add(PerformerNameLabel);
            SelectedSongGroupBox.Controls.Add(SongNameLabel);
            SelectedSongGroupBox.Controls.Add(SongNameTextBox);
            SelectedSongGroupBox.Location = new Point(241, 3);
            SelectedSongGroupBox.Name = "SelectedSongGroupBox";
            SelectedSongGroupBox.Size = new Size(455, 167);
            SelectedSongGroupBox.TabIndex = 1;
            SelectedSongGroupBox.TabStop = false;
            SelectedSongGroupBox.Text = "Selected Song";
            // 
            // ApplyButton
            // 
            ApplyButton.Location = new Point(358, 138);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(91, 23);
            ApplyButton.TabIndex = 8;
            ApplyButton.Text = "Применить";
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // GenreLabel
            // 
            GenreLabel.AutoSize = true;
            GenreLabel.Location = new Point(125, 106);
            GenreLabel.Name = "GenreLabel";
            GenreLabel.Size = new Size(41, 15);
            GenreLabel.TabIndex = 7;
            GenreLabel.Text = "Жанр:";
            // 
            // GenreComboBox
            // 
            GenreComboBox.FormattingEnabled = true;
            GenreComboBox.Location = new Point(172, 103);
            GenreComboBox.Name = "GenreComboBox";
            GenreComboBox.Size = new Size(277, 23);
            GenreComboBox.TabIndex = 6;
            GenreComboBox.SelectedIndexChanged += GenreComboBox_SelectedIndexChanged;
            // 
            // DurationLabel
            // 
            DurationLabel.AutoSize = true;
            DurationLabel.Location = new Point(6, 77);
            DurationLabel.Name = "DurationLabel";
            DurationLabel.Size = new Size(160, 15);
            DurationLabel.TabIndex = 5;
            DurationLabel.Text = "Продолжительность песни:";
            // 
            // DurationTextBox
            // 
            DurationTextBox.Location = new Point(172, 74);
            DurationTextBox.Name = "DurationTextBox";
            DurationTextBox.Size = new Size(277, 23);
            DurationTextBox.TabIndex = 4;
            DurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // PerformerNameTextBox
            // 
            PerformerNameTextBox.Location = new Point(172, 45);
            PerformerNameTextBox.Name = "PerformerNameTextBox";
            PerformerNameTextBox.Size = new Size(277, 23);
            PerformerNameTextBox.TabIndex = 3;
            PerformerNameTextBox.TextChanged += PerformerNameTextBox_TextChanged;
            // 
            // PerformerNameLabel
            // 
            PerformerNameLabel.AutoSize = true;
            PerformerNameLabel.Location = new Point(29, 48);
            PerformerNameLabel.Name = "PerformerNameLabel";
            PerformerNameLabel.Size = new Size(137, 15);
            PerformerNameLabel.TabIndex = 2;
            PerformerNameLabel.Text = "Название исполнителя:";
            // 
            // SongNameLabel
            // 
            SongNameLabel.AutoSize = true;
            SongNameLabel.Location = new Point(68, 19);
            SongNameLabel.Name = "SongNameLabel";
            SongNameLabel.Size = new Size(98, 15);
            SongNameLabel.TabIndex = 1;
            SongNameLabel.Text = "Название песни:";
            // 
            // SongNameTextBox
            // 
            SongNameTextBox.Location = new Point(172, 16);
            SongNameTextBox.Name = "SongNameTextBox";
            SongNameTextBox.Size = new Size(277, 23);
            SongNameTextBox.TabIndex = 0;
            SongNameTextBox.TextChanged += SongNameTextBox_TextChanged;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(3, 403);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(75, 44);
            AddButton.TabIndex = 8;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(79, 403);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(75, 44);
            DeleteButton.TabIndex = 9;
            DeleteButton.Text = "Удалить";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(160, 403);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 44);
            EditButton.TabIndex = 10;
            EditButton.Text = "Редактировать";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // SongsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddButton);
            Controls.Add(DeleteButton);
            Controls.Add(EditButton);
            Controls.Add(SelectedSongGroupBox);
            Controls.Add(SongsListBox);
            Name = "SongsControl";
            Size = new Size(699, 451);
            SelectedSongGroupBox.ResumeLayout(false);
            SelectedSongGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox SongsListBox;
        private GroupBox SelectedSongGroupBox;
        private Label GenreLabel;
        private ComboBox GenreComboBox;
        private Label DurationLabel;
        private TextBox DurationTextBox;
        private TextBox PerformerNameTextBox;
        private Label PerformerNameLabel;
        private Label SongNameLabel;
        private TextBox SongNameTextBox;
        private Button AddButton;
        private Button DeleteButton;
        private Button EditButton;
        private Button ApplyButton;
    }
}
