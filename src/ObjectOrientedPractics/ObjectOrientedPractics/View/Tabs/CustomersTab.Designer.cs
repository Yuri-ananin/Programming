namespace ObjectOrientedPractics.View.Tabs
{
    partial class CustomersTab
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
            Model.Address address2 = new Model.Address();
            CustomersGroupBox = new GroupBox();
            DiscountsListBox = new ListBox();
            RemoveDiscountButton = new Button();
            AddDiscountButton = new Button();
            DiscountsLabel = new Label();
            PriorityCheckBox = new CheckBox();
            AddressControl = new Controls.AddressControl();
            FullNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            FullNameLabel = new Label();
            IdLabel = new Label();
            AddCustomerButton = new Button();
            RemoveButton = new Button();
            EditButton = new Button();
            SaveButton = new Button();
            CustomersListBox = new ListBox();
            DiscountsPanel = new Panel();
            CustomersGroupBox.SuspendLayout();
            DiscountsPanel.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Controls.Add(DiscountsPanel);
            CustomersGroupBox.Controls.Add(PriorityCheckBox);
            CustomersGroupBox.Controls.Add(AddressControl);
            CustomersGroupBox.Controls.Add(FullNameTextBox);
            CustomersGroupBox.Controls.Add(IdTextBox);
            CustomersGroupBox.Controls.Add(FullNameLabel);
            CustomersGroupBox.Controls.Add(IdLabel);
            CustomersGroupBox.Controls.Add(AddCustomerButton);
            CustomersGroupBox.Controls.Add(RemoveButton);
            CustomersGroupBox.Controls.Add(EditButton);
            CustomersGroupBox.Controls.Add(SaveButton);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Dock = DockStyle.Fill;
            CustomersGroupBox.Location = new Point(0, 0);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(807, 567);
            CustomersGroupBox.TabIndex = 0;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // DiscountsListBox
            // 
            DiscountsListBox.FormattingEnabled = true;
            DiscountsListBox.ItemHeight = 15;
            DiscountsListBox.Location = new Point(3, 30);
            DiscountsListBox.Name = "DiscountsListBox";
            DiscountsListBox.Size = new Size(272, 109);
            DiscountsListBox.TabIndex = 14;
            // 
            // RemoveDiscountButton
            // 
            RemoveDiscountButton.Location = new Point(281, 79);
            RemoveDiscountButton.Name = "RemoveDiscountButton";
            RemoveDiscountButton.Size = new Size(88, 43);
            RemoveDiscountButton.TabIndex = 13;
            RemoveDiscountButton.Text = "Remove";
            RemoveDiscountButton.UseVisualStyleBackColor = true;
            RemoveDiscountButton.Click += RemoveDiscountButton_Click;
            // 
            // AddDiscountButton
            // 
            AddDiscountButton.Location = new Point(281, 30);
            AddDiscountButton.Name = "AddDiscountButton";
            AddDiscountButton.Size = new Size(88, 43);
            AddDiscountButton.TabIndex = 12;
            AddDiscountButton.Text = "Add";
            AddDiscountButton.UseVisualStyleBackColor = true;
            AddDiscountButton.Click += AddDiscountButton_Click;
            // 
            // DiscountsLabel
            // 
            DiscountsLabel.AutoSize = true;
            DiscountsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DiscountsLabel.Location = new Point(3, 12);
            DiscountsLabel.Name = "DiscountsLabel";
            DiscountsLabel.Size = new Size(61, 15);
            DiscountsLabel.TabIndex = 11;
            DiscountsLabel.Text = "Discounts";
            // 
            // PriorityCheckBox
            // 
            PriorityCheckBox.AutoSize = true;
            PriorityCheckBox.Location = new Point(303, 96);
            PriorityCheckBox.Name = "PriorityCheckBox";
            PriorityCheckBox.Size = new Size(75, 19);
            PriorityCheckBox.TabIndex = 10;
            PriorityCheckBox.Text = "Is Priority";
            PriorityCheckBox.UseVisualStyleBackColor = true;
            PriorityCheckBox.CheckedChanged += PriorityCheckBox_CheckedChanged;
            // 
            // AddressControl
            // 
            address2.Apartment = null;
            address2.Building = null;
            address2.City = null;
            address2.Country = null;
            address2.Index = 0;
            address2.Street = null;
            AddressControl.Address = address2;
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.Location = new Point(303, 121);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(497, 151);
            AddressControl.TabIndex = 1;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullNameTextBox.Location = new Point(373, 60);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(428, 23);
            FullNameTextBox.TabIndex = 9;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(373, 32);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(121, 23);
            IdTextBox.TabIndex = 8;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(303, 63);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 6;
            FullNameLabel.Text = "Full Name:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(303, 35);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 5;
            IdLabel.Text = "ID:";
            // 
            // AddCustomerButton
            // 
            AddCustomerButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddCustomerButton.Location = new Point(3, 497);
            AddCustomerButton.Name = "AddCustomerButton";
            AddCustomerButton.Size = new Size(86, 23);
            AddCustomerButton.TabIndex = 1;
            AddCustomerButton.Text = "Add";
            AddCustomerButton.UseVisualStyleBackColor = true;
            AddCustomerButton.Click += AddCustomerButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Location = new Point(3, 536);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(86, 25);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // EditButton
            // 
            EditButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            EditButton.Location = new Point(95, 507);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(100, 40);
            EditButton.TabIndex = 3;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            SaveButton.Location = new Point(197, 507);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(100, 40);
            SaveButton.TabIndex = 4;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.ItemHeight = 15;
            CustomersListBox.Location = new Point(0, 22);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(297, 469);
            CustomersListBox.TabIndex = 0;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // DiscountsPanel
            // 
            DiscountsPanel.Controls.Add(DiscountsLabel);
            DiscountsPanel.Controls.Add(RemoveDiscountButton);
            DiscountsPanel.Controls.Add(DiscountsListBox);
            DiscountsPanel.Controls.Add(AddDiscountButton);
            DiscountsPanel.Location = new Point(303, 278);
            DiscountsPanel.Name = "DiscountsPanel";
            DiscountsPanel.Size = new Size(498, 146);
            DiscountsPanel.TabIndex = 15;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomersGroupBox);
            Name = "CustomersTab";
            Size = new Size(807, 567);
            CustomersGroupBox.ResumeLayout(false);
            CustomersGroupBox.PerformLayout();
            DiscountsPanel.ResumeLayout(false);
            DiscountsPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomersGroupBox;
        private ListBox CustomersListBox;
        private Button AddCustomerButton;
        private Button RemoveButton;
        private Button EditButton;
        private Button SaveButton;
        private TextBox IdTextBox;
        private Label FullNameLabel;
        private Label IdLabel;
        private TextBox FullNameTextBox;
        private Controls.AddressControl AddressControl;
        private CheckBox PriorityCheckBox;
        private ListBox DiscountsListBox;
        private Button RemoveDiscountButton;
        private Button AddDiscountButton;
        private Label DiscountsLabel;
        private Panel DiscountsPanel;
    }
}
