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
            SongsGroupBox = new GroupBox();
            SongDurationErrorLabel = new Label();
            ArtistNameErrorLabel = new Label();
            SongNameErrorLabel = new Label();
            AddButton = new Button();
            ApplyButton = new Button();
            EditButton = new Button();
            RemoveButton = new Button();
            SongGenreLabel = new Label();
            SongGenreComboBox = new ComboBox();
            SongDurationLabel = new Label();
            SongDurationTextBox = new TextBox();
            ArtistNameTextBox = new TextBox();
            ArtistNameLabel = new Label();
            SongNameLabel = new Label();
            SongNameTextBox = new TextBox();
            SongsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // SongsListBox
            // 
            SongsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            SongsListBox.FormattingEnabled = true;
            SongsListBox.ItemHeight = 15;
            SongsListBox.Location = new Point(3, 19);
            SongsListBox.Name = "SongsListBox";
            SongsListBox.Size = new Size(241, 349);
            SongsListBox.TabIndex = 0;
            SongsListBox.SelectedIndexChanged += SongsListBox_SelectedIndexChanged;
            // 
            // SongsGroupBox
            // 
            SongsGroupBox.Controls.Add(SongDurationErrorLabel);
            SongsGroupBox.Controls.Add(ArtistNameErrorLabel);
            SongsGroupBox.Controls.Add(SongNameErrorLabel);
            SongsGroupBox.Controls.Add(AddButton);
            SongsGroupBox.Controls.Add(ApplyButton);
            SongsGroupBox.Controls.Add(EditButton);
            SongsGroupBox.Controls.Add(RemoveButton);
            SongsGroupBox.Controls.Add(SongGenreLabel);
            SongsGroupBox.Controls.Add(SongGenreComboBox);
            SongsGroupBox.Controls.Add(SongDurationLabel);
            SongsGroupBox.Controls.Add(SongsListBox);
            SongsGroupBox.Controls.Add(SongDurationTextBox);
            SongsGroupBox.Controls.Add(ArtistNameTextBox);
            SongsGroupBox.Controls.Add(ArtistNameLabel);
            SongsGroupBox.Controls.Add(SongNameLabel);
            SongsGroupBox.Controls.Add(SongNameTextBox);
            SongsGroupBox.Dock = DockStyle.Fill;
            SongsGroupBox.Location = new Point(0, 0);
            SongsGroupBox.Name = "SongsGroupBox";
            SongsGroupBox.Size = new Size(699, 425);
            SongsGroupBox.TabIndex = 0;
            SongsGroupBox.TabStop = false;
            SongsGroupBox.Text = "Songs List";
            // 
            // SongDurationErrorLabel
            // 
            SongDurationErrorLabel.AutoSize = true;
            SongDurationErrorLabel.BackColor = Color.FromArgb(255, 128, 128);
            SongDurationErrorLabel.Location = new Point(264, 184);
            SongDurationErrorLabel.Name = "SongDurationErrorLabel";
            SongDurationErrorLabel.Size = new Size(154, 15);
            SongDurationErrorLabel.TabIndex = 13;
            SongDurationErrorLabel.Text = "Введите число от 1 до 7200";
            SongDurationErrorLabel.Visible = false;
            // 
            // ArtistNameErrorLabel
            // 
            ArtistNameErrorLabel.AutoSize = true;
            ArtistNameErrorLabel.BackColor = Color.FromArgb(255, 128, 128);
            ArtistNameErrorLabel.Location = new Point(264, 124);
            ArtistNameErrorLabel.Name = "ArtistNameErrorLabel";
            ArtistNameErrorLabel.Size = new Size(324, 15);
            ArtistNameErrorLabel.TabIndex = 12;
            ArtistNameErrorLabel.Text = "Введите только латинские буквы (не более 50 символов) ";
            ArtistNameErrorLabel.Visible = false;
            // 
            // SongNameErrorLabel
            // 
            SongNameErrorLabel.AutoSize = true;
            SongNameErrorLabel.BackColor = Color.FromArgb(255, 128, 128);
            SongNameErrorLabel.Location = new Point(264, 63);
            SongNameErrorLabel.Name = "SongNameErrorLabel";
            SongNameErrorLabel.Size = new Size(321, 15);
            SongNameErrorLabel.TabIndex = 11;
            SongNameErrorLabel.Text = "Введите только латинские буквы (не более 50 символов)";
            SongNameErrorLabel.Visible = false;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.BackColor = SystemColors.Control;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Image = Properties.Resources.music_player__1_1;
            AddButton.Location = new Point(6, 379);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(40, 40);
            AddButton.TabIndex = 1;
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // ApplyButton
            // 
            ApplyButton.FlatAppearance.BorderSize = 0;
            ApplyButton.FlatStyle = FlatStyle.Flat;
            ApplyButton.Image = Properties.Resources.check__1_;
            ApplyButton.Location = new Point(616, 263);
            ApplyButton.Name = "ApplyButton";
            ApplyButton.Size = new Size(62, 57);
            ApplyButton.TabIndex = 8;
            ApplyButton.UseVisualStyleBackColor = true;
            ApplyButton.Click += ApplyButton_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditButton.FlatAppearance.BorderSize = 0;
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.Image = Properties.Resources.draw__1_;
            EditButton.Location = new Point(204, 380);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(40, 40);
            EditButton.TabIndex = 10;
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.FlatAppearance.BorderSize = 0;
            RemoveButton.FlatStyle = FlatStyle.Flat;
            RemoveButton.Image = Properties.Resources.remove__1_;
            RemoveButton.Location = new Point(105, 379);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(40, 40);
            RemoveButton.TabIndex = 9;
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += DeleteButton_Click;
            // 
            // SongGenreLabel
            // 
            SongGenreLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SongGenreLabel.AutoSize = true;
            SongGenreLabel.Location = new Point(264, 204);
            SongGenreLabel.Name = "SongGenreLabel";
            SongGenreLabel.Size = new Size(71, 15);
            SongGenreLabel.TabIndex = 7;
            SongGenreLabel.Text = "Song Genre:";
            // 
            // SongGenreComboBox
            // 
            SongGenreComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SongGenreComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SongGenreComboBox.FormattingEnabled = true;
            SongGenreComboBox.Location = new Point(264, 222);
            SongGenreComboBox.Name = "SongGenreComboBox";
            SongGenreComboBox.Size = new Size(414, 23);
            SongGenreComboBox.TabIndex = 6;
            SongGenreComboBox.SelectedIndexChanged += GenreComboBox_SelectedIndexChanged;
            // 
            // SongDurationLabel
            // 
            SongDurationLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SongDurationLabel.AutoSize = true;
            SongDurationLabel.Location = new Point(264, 140);
            SongDurationLabel.Name = "SongDurationLabel";
            SongDurationLabel.Size = new Size(86, 15);
            SongDurationLabel.TabIndex = 5;
            SongDurationLabel.Text = "Song Duration:";
            // 
            // SongDurationTextBox
            // 
            SongDurationTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SongDurationTextBox.Location = new Point(264, 158);
            SongDurationTextBox.Name = "SongDurationTextBox";
            SongDurationTextBox.Size = new Size(414, 23);
            SongDurationTextBox.TabIndex = 4;
            SongDurationTextBox.TextChanged += DurationTextBox_TextChanged;
            // 
            // ArtistNameTextBox
            // 
            ArtistNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ArtistNameTextBox.Location = new Point(264, 98);
            ArtistNameTextBox.Name = "ArtistNameTextBox";
            ArtistNameTextBox.Size = new Size(414, 23);
            ArtistNameTextBox.TabIndex = 3;
            ArtistNameTextBox.TextChanged += ArtistNameTextBox_TextChanged;
            // 
            // ArtistNameLabel
            // 
            ArtistNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ArtistNameLabel.AutoSize = true;
            ArtistNameLabel.Location = new Point(264, 80);
            ArtistNameLabel.Name = "ArtistNameLabel";
            ArtistNameLabel.Size = new Size(73, 15);
            ArtistNameLabel.TabIndex = 2;
            ArtistNameLabel.Text = "Artist Name:";
            // 
            // SongNameLabel
            // 
            SongNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SongNameLabel.AutoSize = true;
            SongNameLabel.Location = new Point(264, 19);
            SongNameLabel.Name = "SongNameLabel";
            SongNameLabel.Size = new Size(72, 15);
            SongNameLabel.TabIndex = 1;
            SongNameLabel.Text = "Song Name:";
            // 
            // SongNameTextBox
            // 
            SongNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SongNameTextBox.Location = new Point(264, 37);
            SongNameTextBox.Name = "SongNameTextBox";
            SongNameTextBox.Size = new Size(414, 23);
            SongNameTextBox.TabIndex = 0;
            SongNameTextBox.TextChanged += SongNameTextBox_TextChanged;
            // 
            // SongsControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SongsGroupBox);
            Name = "SongsControl";
            Size = new Size(699, 425);
            SongsGroupBox.ResumeLayout(false);
            SongsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox SongsListBox;
        private GroupBox SongsGroupBox;
        private Label SongGenreLabel;
        private ComboBox SongGenreComboBox;
        private Label SongDurationLabel;
        private TextBox SongDurationTextBox;
        private TextBox ArtistNameTextBox;
        private Label ArtistNameLabel;
        private Label SongNameLabel;
        private TextBox SongNameTextBox;
        private Button AddButton;
        private Button RemoveButton;
        private Button EditButton;
        private Button ApplyButton;
        private Label SongDurationErrorLabel;
        private Label ArtistNameErrorLabel;
        private Label SongNameErrorLabel;
    }
}
