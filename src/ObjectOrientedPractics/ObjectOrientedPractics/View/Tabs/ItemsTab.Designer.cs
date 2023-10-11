namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
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
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            AddButton = new Button();
            IdTextBox = new TextBox();
            DescriptionLabel = new Label();
            RemoveButton = new Button();
            CostTextBox = new TextBox();
            NameLabel = new Label();
            NameTextBox = new TextBox();
            IdLabel = new Label();
            CostLabel = new Label();
            DescriptionTextBox = new TextBox();
            ItemsListBox = new ListBox();
            AddItemButton = new Button();
            ItemsGroupBox = new GroupBox();
            SaveButton = new Button();
            EditButton = new Button();
            ItemsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(502, 789);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(85, 34);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(341, 37);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(120, 23);
            IdTextBox.TabIndex = 4;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(304, 236);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(70, 15);
            DescriptionLabel.TabIndex = 3;
            DescriptionLabel.Text = "Description:";
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Location = new Point(98, 506);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(87, 52);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(341, 71);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(120, 23);
            CostTextBox.TabIndex = 5;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(304, 116);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name:";
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(304, 134);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(560, 99);
            NameTextBox.TabIndex = 6;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(304, 45);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 0;
            IdLabel.Text = "ID:";
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(304, 74);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 1;
            CostLabel.Text = "Cost:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(304, 254);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(560, 202);
            DescriptionTextBox.TabIndex = 7;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(6, 19);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(266, 484);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.Location = new Point(6, 506);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(86, 52);
            AddItemButton.TabIndex = 8;
            AddItemButton.Text = "Add";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Controls.Add(SaveButton);
            ItemsGroupBox.Controls.Add(EditButton);
            ItemsGroupBox.Controls.Add(AddItemButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Controls.Add(DescriptionTextBox);
            ItemsGroupBox.Controls.Add(CostLabel);
            ItemsGroupBox.Controls.Add(IdLabel);
            ItemsGroupBox.Controls.Add(NameTextBox);
            ItemsGroupBox.Controls.Add(NameLabel);
            ItemsGroupBox.Controls.Add(CostTextBox);
            ItemsGroupBox.Controls.Add(RemoveButton);
            ItemsGroupBox.Controls.Add(DescriptionLabel);
            ItemsGroupBox.Controls.Add(IdTextBox);
            ItemsGroupBox.Dock = DockStyle.Fill;
            ItemsGroupBox.Location = new Point(0, 0);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(904, 567);
            ItemsGroupBox.TabIndex = 8;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveButton.Location = new Point(191, 535);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(75, 23);
            SaveButton.TabIndex = 11;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditButton.Location = new Point(191, 506);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(75, 23);
            EditButton.TabIndex = 10;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ItemsGroupBox);
            Controls.Add(AddButton);
            Name = "ItemsTab";
            Size = new Size(904, 567);
            ItemsGroupBox.ResumeLayout(false);
            ItemsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Button AddButton;
        private TextBox IdTextBox;
        private Label DescriptionLabel;
        private Button RemoveButton;
        private TextBox CostTextBox;
        private Label NameLabel;
        private TextBox NameTextBox;
        private Label IdLabel;
        private Label CostLabel;
        private TextBox DescriptionTextBox;
        private ListBox ItemsListBox;
        private Button AddItemButton;
        private GroupBox ItemsGroupBox;
        private Button SaveButton;
        private Button EditButton;
    }
}
