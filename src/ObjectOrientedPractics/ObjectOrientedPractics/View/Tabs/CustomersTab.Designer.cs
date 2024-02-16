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
            Model.Address address1 = new Model.Address();
            CustomersGroupBox = new GroupBox();
            AddressControl = new Controls.AddressControl();
            FullNameTextBox = new TextBox();
            IdTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            AddCustomerButton = new Button();
            RemoveButton = new Button();
            EditButton = new Button();
            SaveButton = new Button();
            CustomersListBox = new ListBox();
            CustomersGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Controls.Add(AddressControl);
            CustomersGroupBox.Controls.Add(FullNameTextBox);
            CustomersGroupBox.Controls.Add(IdTextBox);
            CustomersGroupBox.Controls.Add(label2);
            CustomersGroupBox.Controls.Add(label1);
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
            // AddressControl
            // 
            address1.Apartment = null;
            address1.Building = null;
            address1.City = null;
            address1.Country = null;
            address1.Index = 0;
            address1.Street = null;
            AddressControl.Address = address1;
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.Location = new Point(303, 89);
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
            IdTextBox.Location = new Point(373, 32);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(121, 23);
            IdTextBox.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(303, 63);
            label2.Name = "label2";
            label2.Size = new Size(64, 15);
            label2.TabIndex = 6;
            label2.Text = "Full Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 35);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 5;
            label1.Text = "ID:";
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
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CustomersGroupBox);
            Name = "CustomersTab";
            Size = new Size(807, 567);
            CustomersGroupBox.ResumeLayout(false);
            CustomersGroupBox.PerformLayout();
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
        private Label label2;
        private Label label1;
        private TextBox FullNameTextBox;
        private Controls.AddressControl AddressControl;
    }
}
