namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            SelectedOrderLabel = new Label();
            IdLabel = new Label();
            CreatedTimeLabel = new Label();
            StatusLabel = new Label();
            IDTextBox = new TextBox();
            CreatedTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            PriorityOptionsLabel = new Label();
            DeliveryTimeLabel = new Label();
            DeliveryComboBox = new ComboBox();
            OrderItemsLabel = new Label();
            AmountLabel = new Label();
            PriceLabel = new Label();
            OrderItemsListBox = new ListBox();
            AddItemButton = new Button();
            RemoveButton = new Button();
            ClearButton = new Button();
            AddressControl = new Controls.AddressControl();
            SuspendLayout();
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SelectedOrderLabel.Location = new Point(3, 0);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(92, 15);
            SelectedOrderLabel.TabIndex = 0;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(3, 26);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 1;
            IdLabel.Text = "ID:";
            // 
            // CreatedTimeLabel
            // 
            CreatedTimeLabel.AutoSize = true;
            CreatedTimeLabel.Location = new Point(3, 59);
            CreatedTimeLabel.Name = "CreatedTimeLabel";
            CreatedTimeLabel.Size = new Size(51, 15);
            CreatedTimeLabel.TabIndex = 2;
            CreatedTimeLabel.Text = "Created:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(3, 93);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 15);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Status:";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(56, 18);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(236, 23);
            IDTextBox.TabIndex = 4;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Location = new Point(56, 51);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.ReadOnly = true;
            CreatedTextBox.Size = new Size(236, 23);
            CreatedTextBox.TabIndex = 5;
            // 
            // StatusComboBox
            // 
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(56, 85);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(236, 23);
            StatusComboBox.TabIndex = 6;
            // 
            // PriorityOptionsLabel
            // 
            PriorityOptionsLabel.AutoSize = true;
            PriorityOptionsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PriorityOptionsLabel.Location = new Point(605, 0);
            PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            PriorityOptionsLabel.Size = new Size(94, 15);
            PriorityOptionsLabel.TabIndex = 7;
            PriorityOptionsLabel.Text = "Priority Options";
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(605, 34);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(81, 15);
            DeliveryTimeLabel.TabIndex = 8;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // DeliveryComboBox
            // 
            DeliveryComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DeliveryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DeliveryComboBox.FormattingEnabled = true;
            DeliveryComboBox.Location = new Point(692, 31);
            DeliveryComboBox.Name = "DeliveryComboBox";
            DeliveryComboBox.Size = new Size(234, 23);
            DeliveryComboBox.TabIndex = 9;
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            OrderItemsLabel.Location = new Point(3, 311);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(75, 15);
            OrderItemsLabel.TabIndex = 23;
            OrderItemsLabel.Text = "Order Items";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AmountLabel.Location = new Point(882, 501);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(55, 15);
            AmountLabel.TabIndex = 24;
            AmountLabel.Text = "Amount:";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            PriceLabel.Location = new Point(882, 516);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(17, 19);
            PriceLabel.TabIndex = 25;
            PriceLabel.Text = "0";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(3, 329);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(934, 169);
            OrderItemsListBox.TabIndex = 26;
            // 
            // AddItemButton
            // 
            AddItemButton.Location = new Point(3, 541);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(100, 36);
            AddItemButton.TabIndex = 27;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            AddItemButton.Click += AddItemButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(109, 541);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(100, 36);
            RemoveButton.TabIndex = 28;
            RemoveButton.Text = "Remove Item";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveItemButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(837, 541);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(100, 36);
            ClearButton.TabIndex = 29;
            ClearButton.Text = "Clear Order";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
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
            AddressControl.Enabled = false;
            AddressControl.Location = new Point(0, 139);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(937, 151);
            AddressControl.TabIndex = 30;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AddressControl);
            Controls.Add(ClearButton);
            Controls.Add(RemoveButton);
            Controls.Add(AddItemButton);
            Controls.Add(OrderItemsListBox);
            Controls.Add(PriceLabel);
            Controls.Add(AmountLabel);
            Controls.Add(OrderItemsLabel);
            Controls.Add(DeliveryComboBox);
            Controls.Add(DeliveryTimeLabel);
            Controls.Add(PriorityOptionsLabel);
            Controls.Add(StatusComboBox);
            Controls.Add(CreatedTextBox);
            Controls.Add(IDTextBox);
            Controls.Add(StatusLabel);
            Controls.Add(CreatedTimeLabel);
            Controls.Add(IdLabel);
            Controls.Add(SelectedOrderLabel);
            Name = "PriorityOrdersTab";
            Size = new Size(940, 580);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SelectedOrderLabel;
        private Label IdLabel;
        private Label CreatedTimeLabel;
        private Label StatusLabel;
        private TextBox IDTextBox;
        private TextBox CreatedTextBox;
        private ComboBox StatusComboBox;
        private Label PriorityOptionsLabel;
        private Label DeliveryTimeLabel;
        private ComboBox DeliveryComboBox;
        private Label OrderItemsLabel;
        private Label AmountLabel;
        private Label PriceLabel;
        private ListBox OrderItemsListBox;
        private Button AddItemButton;
        private Button RemoveButton;
        private Button ClearButton;
        private Controls.AddressControl AddressControl;
    }
}
