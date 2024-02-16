namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            OrdersDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            OrderStatusColumn = new DataGridViewTextBoxColumn();
            AmountColumn = new DataGridViewTextBoxColumn();
            OrdersGroupBox = new GroupBox();
            PriceLabel = new Label();
            AmountLabel = new Label();
            OrderItemsListBox = new ListBox();
            OrderItemsLabel = new Label();
            DeliveryAddressControl = new Controls.AddressControl();
            StatusComboBox = new ComboBox();
            DateTextBox = new TextBox();
            IdTextBox = new TextBox();
            SelectedOrderLabel = new Label();
            StatusLabel = new Label();
            DateLabel = new Label();
            IdLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            OrdersGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, Date, FullName, Address, OrderStatusColumn, AmountColumn });
            OrdersDataGridView.Location = new Point(-3, 22);
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.RowTemplate.Height = 25;
            OrdersDataGridView.Size = new Size(435, 494);
            OrdersDataGridView.TabIndex = 0;
            OrdersDataGridView.CellContentClick += OrdersDataGridView_CellContentClick;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Date
            // 
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.ReadOnly = true;
            Date.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // FullName
            // 
            FullName.HeaderText = "FullName";
            FullName.Name = "FullName";
            FullName.ReadOnly = true;
            FullName.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // Address
            // 
            Address.HeaderText = "Address";
            Address.Name = "Address";
            Address.ReadOnly = true;
            Address.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OrderStatusColumn
            // 
            OrderStatusColumn.HeaderText = "OrderStatus";
            OrderStatusColumn.Name = "OrderStatusColumn";
            OrderStatusColumn.ReadOnly = true;
            OrderStatusColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // AmountColumn
            // 
            AmountColumn.HeaderText = "Amount";
            AmountColumn.Name = "AmountColumn";
            AmountColumn.ReadOnly = true;
            AmountColumn.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // OrdersGroupBox
            // 
            OrdersGroupBox.Controls.Add(PriceLabel);
            OrdersGroupBox.Controls.Add(AmountLabel);
            OrdersGroupBox.Controls.Add(OrderItemsListBox);
            OrdersGroupBox.Controls.Add(OrderItemsLabel);
            OrdersGroupBox.Controls.Add(DeliveryAddressControl);
            OrdersGroupBox.Controls.Add(StatusComboBox);
            OrdersGroupBox.Controls.Add(DateTextBox);
            OrdersGroupBox.Controls.Add(IdTextBox);
            OrdersGroupBox.Controls.Add(SelectedOrderLabel);
            OrdersGroupBox.Controls.Add(StatusLabel);
            OrdersGroupBox.Controls.Add(DateLabel);
            OrdersGroupBox.Controls.Add(IdLabel);
            OrdersGroupBox.Controls.Add(OrdersDataGridView);
            OrdersGroupBox.Location = new Point(3, 3);
            OrdersGroupBox.Name = "OrdersGroupBox";
            OrdersGroupBox.Size = new Size(930, 565);
            OrdersGroupBox.TabIndex = 1;
            OrdersGroupBox.TabStop = false;
            OrdersGroupBox.Text = "Orders";
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(889, 547);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(13, 15);
            PriceLabel.TabIndex = 12;
            PriceLabel.Text = "0";
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(870, 519);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(54, 15);
            AmountLabel.TabIndex = 11;
            AmountLabel.Text = "Amount:";
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Enabled = false;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(438, 347);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(486, 169);
            OrderItemsListBox.TabIndex = 10;
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Location = new Point(438, 329);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(69, 15);
            OrderItemsLabel.TabIndex = 9;
            OrderItemsLabel.Text = "Order Items";
            // 
            // DeliveryAddressControl
            // 
            address1.Apartment = null;
            address1.Building = null;
            address1.City = null;
            address1.Country = null;
            address1.Index = 0;
            address1.Street = null;
            DeliveryAddressControl.Address = address1;
            DeliveryAddressControl.Enabled = false;
            DeliveryAddressControl.Location = new Point(438, 175);
            DeliveryAddressControl.Name = "DeliveryAddressControl";
            DeliveryAddressControl.Size = new Size(492, 151);
            DeliveryAddressControl.TabIndex = 8;
            // 
            // StatusComboBox
            // 
            StatusComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(495, 123);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(121, 23);
            StatusComboBox.TabIndex = 7;
            StatusComboBox.SelectedIndexChanged += StatusComboBox_SelectedIndexChanged;
            // 
            // DateTextBox
            // 
            DateTextBox.Enabled = false;
            DateTextBox.Location = new Point(495, 82);
            DateTextBox.Name = "DateTextBox";
            DateTextBox.Size = new Size(121, 23);
            DateTextBox.TabIndex = 6;
            // 
            // IdTextBox
            // 
            IdTextBox.Enabled = false;
            IdTextBox.Location = new Point(495, 43);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.Size = new Size(121, 23);
            IdTextBox.TabIndex = 5;
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Location = new Point(438, 19);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(84, 15);
            SelectedOrderLabel.TabIndex = 4;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(438, 126);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 15);
            StatusLabel.TabIndex = 3;
            StatusLabel.Text = "Status:";
            // 
            // DateLabel
            // 
            DateLabel.AutoSize = true;
            DateLabel.Location = new Point(438, 85);
            DateLabel.Name = "DateLabel";
            DateLabel.Size = new Size(51, 15);
            DateLabel.TabIndex = 2;
            DateLabel.Text = "Created:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(438, 46);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 1;
            IdLabel.Text = "ID:";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OrdersGroupBox);
            Name = "OrdersTab";
            Size = new Size(936, 571);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            OrdersGroupBox.ResumeLayout(false);
            OrdersGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView OrdersDataGridView;
        private GroupBox OrdersGroupBox;
        private ComboBox StatusComboBox;
        private TextBox DateTextBox;
        private TextBox IdTextBox;
        private Label SelectedOrderLabel;
        private Label StatusLabel;
        private Label DateLabel;
        private Label IdLabel;
        private Controls.AddressControl DeliveryAddressControl;
        private Label PriceLabel;
        private Label AmountLabel;
        private ListBox OrderItemsListBox;
        private Label OrderItemsLabel;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn OrderStatusColumn;
        private DataGridViewTextBoxColumn AmountColumn;
    }
}
