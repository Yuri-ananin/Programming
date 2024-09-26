namespace ObjectOrientedPractics.View.Tabs
{
    partial class CartsTab
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
            CartsGroupBox = new GroupBox();
            TotalCostLabel = new Label();
            TotalLabel = new Label();
            DiscountAmountLabel = new Label();
            AmountDiscountLabel = new Label();
            DiscountsLabel = new Label();
            DiscountsCheckedListBox = new CheckedListBox();
            CustomersComboBox = new ComboBox();
            PriceLabel = new Label();
            AmountLabel = new Label();
            ClearButton = new Button();
            RemoveButton = new Button();
            CreateButton = new Button();
            CartListBox = new ListBox();
            CartLabel = new Label();
            CustomerLabel = new Label();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            CartsGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CartsGroupBox
            // 
            CartsGroupBox.Controls.Add(TotalCostLabel);
            CartsGroupBox.Controls.Add(TotalLabel);
            CartsGroupBox.Controls.Add(DiscountAmountLabel);
            CartsGroupBox.Controls.Add(AmountDiscountLabel);
            CartsGroupBox.Controls.Add(DiscountsLabel);
            CartsGroupBox.Controls.Add(DiscountsCheckedListBox);
            CartsGroupBox.Controls.Add(CustomersComboBox);
            CartsGroupBox.Controls.Add(PriceLabel);
            CartsGroupBox.Controls.Add(AmountLabel);
            CartsGroupBox.Controls.Add(ClearButton);
            CartsGroupBox.Controls.Add(RemoveButton);
            CartsGroupBox.Controls.Add(CreateButton);
            CartsGroupBox.Controls.Add(CartListBox);
            CartsGroupBox.Controls.Add(CartLabel);
            CartsGroupBox.Controls.Add(CustomerLabel);
            CartsGroupBox.Controls.Add(AddButton);
            CartsGroupBox.Controls.Add(ItemsListBox);
            CartsGroupBox.Dock = DockStyle.Fill;
            CartsGroupBox.Location = new Point(0, 0);
            CartsGroupBox.Name = "CartsGroupBox";
            CartsGroupBox.Size = new Size(936, 571);
            CartsGroupBox.TabIndex = 0;
            CartsGroupBox.TabStop = false;
            CartsGroupBox.Text = "Carts";
            // 
            // TotalCostLabel
            // 
            TotalCostLabel.AutoSize = true;
            TotalCostLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            TotalCostLabel.Location = new Point(856, 539);
            TotalCostLabel.Name = "TotalCostLabel";
            TotalCostLabel.Size = new Size(18, 20);
            TotalCostLabel.TabIndex = 16;
            TotalCostLabel.Text = "0";
            // 
            // TotalLabel
            // 
            TotalLabel.AutoSize = true;
            TotalLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            TotalLabel.Location = new Point(837, 520);
            TotalLabel.Name = "TotalLabel";
            TotalLabel.Size = new Size(54, 19);
            TotalLabel.TabIndex = 15;
            TotalLabel.Text = "TOTAL:";
            // 
            // DiscountAmountLabel
            // 
            DiscountAmountLabel.AutoSize = true;
            DiscountAmountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DiscountAmountLabel.Location = new Point(784, 353);
            DiscountAmountLabel.Name = "DiscountAmountLabel";
            DiscountAmountLabel.Size = new Size(107, 15);
            DiscountAmountLabel.TabIndex = 14;
            DiscountAmountLabel.Text = "Discount Amount:";
            // 
            // AmountDiscountLabel
            // 
            AmountDiscountLabel.AutoSize = true;
            AmountDiscountLabel.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            AmountDiscountLabel.Location = new Point(837, 368);
            AmountDiscountLabel.Name = "AmountDiscountLabel";
            AmountDiscountLabel.Size = new Size(18, 20);
            AmountDiscountLabel.TabIndex = 13;
            AmountDiscountLabel.Text = "0";
            // 
            // DiscountsLabel
            // 
            DiscountsLabel.AutoSize = true;
            DiscountsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            DiscountsLabel.Location = new Point(357, 335);
            DiscountsLabel.Name = "DiscountsLabel";
            DiscountsLabel.Size = new Size(64, 15);
            DiscountsLabel.TabIndex = 12;
            DiscountsLabel.Text = "Discounts:\r\n";
            // 
            // DiscountsCheckedListBox
            // 
            DiscountsCheckedListBox.BackColor = SystemColors.Control;
            DiscountsCheckedListBox.BorderStyle = BorderStyle.None;
            DiscountsCheckedListBox.CheckOnClick = true;
            DiscountsCheckedListBox.FormattingEnabled = true;
            DiscountsCheckedListBox.IntegralHeight = false;
            DiscountsCheckedListBox.Location = new Point(357, 353);
            DiscountsCheckedListBox.Name = "DiscountsCheckedListBox";
            DiscountsCheckedListBox.Size = new Size(224, 165);
            DiscountsCheckedListBox.TabIndex = 1;
            DiscountsCheckedListBox.SelectedIndexChanged += DiscountsCheckedListBox_SelectedIndexChanged;
            // 
            // CustomersComboBox
            // 
            CustomersComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            CustomersComboBox.FormattingEnabled = true;
            CustomersComboBox.Location = new Point(425, 23);
            CustomersComboBox.Name = "CustomersComboBox";
            CustomersComboBox.Size = new Size(466, 23);
            CustomersComboBox.TabIndex = 11;
            CustomersComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // PriceLabel
            // 
            PriceLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            PriceLabel.AutoSize = true;
            PriceLabel.Location = new Point(856, 264);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(13, 15);
            PriceLabel.TabIndex = 10;
            PriceLabel.Text = "0";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.AutoSize = true;
            AmountLabel.Location = new Point(837, 240);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(54, 15);
            AmountLabel.TabIndex = 9;
            AmountLabel.Text = "Amount:";
            // 
            // ClearButton
            // 
            ClearButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearButton.Location = new Point(803, 282);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(88, 33);
            ClearButton.TabIndex = 8;
            ClearButton.Text = "Clear Cart";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemoveButton.Location = new Point(709, 282);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(88, 33);
            RemoveButton.TabIndex = 7;
            RemoveButton.Text = "Remove Item";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // CreateButton
            // 
            CreateButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            CreateButton.Location = new Point(357, 282);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(88, 33);
            CreateButton.TabIndex = 6;
            CreateButton.Text = "Create Order";
            CreateButton.UseVisualStyleBackColor = true;
            CreateButton.Click += CreateButton_Click;
            // 
            // CartListBox
            // 
            CartListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CartListBox.FormattingEnabled = true;
            CartListBox.ItemHeight = 15;
            CartListBox.Location = new Point(357, 83);
            CartListBox.Name = "CartListBox";
            CartListBox.Size = new Size(534, 154);
            CartListBox.TabIndex = 5;
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(357, 64);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(32, 15);
            CartLabel.TabIndex = 4;
            CartLabel.Text = "Cart:";
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Location = new Point(357, 23);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(62, 15);
            CustomerLabel.TabIndex = 2;
            CustomerLabel.Text = "Customer:";
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.Location = new Point(6, 524);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(92, 35);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add To Cart";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(3, 19);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(308, 499);
            ItemsListBox.TabIndex = 0;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CartsGroupBox);
            Name = "CartsTab";
            Size = new Size(936, 571);
            CartsGroupBox.ResumeLayout(false);
            CartsGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CartsGroupBox;
        private Label CustomerLabel;
        private Button AddButton;
        private ListBox ItemsListBox;
        private Label PriceLabel;
        private Label AmountLabel;
        private Button ClearButton;
        private Button RemoveButton;
        private Button CreateButton;
        private ListBox CartListBox;
        private Label CartLabel;
        private ComboBox CustomersComboBox;
        private Label TotalCostLabel;
        private Label TotalLabel;
        private Label DiscountAmountLabel;
        private Label AmountDiscountLabel;
        private Label DiscountsLabel;
        private CheckedListBox DiscountsCheckedListBox;
    }
}
