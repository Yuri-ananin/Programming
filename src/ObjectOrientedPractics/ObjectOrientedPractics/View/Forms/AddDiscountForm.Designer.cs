namespace ObjectOrientedPractics.View.Forms
{
    partial class AddDiscountForm
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
            OkButton = new Button();
            CancelButton = new Button();
            PercentDiscountLabel = new Label();
            CategoryLabel = new Label();
            DiscountCategoryComboBox = new ComboBox();
            SuspendLayout();
            // 
            // OkButton
            // 
            OkButton.Location = new Point(107, 89);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(100, 39);
            OkButton.TabIndex = 0;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Click += OkButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(213, 89);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(100, 39);
            CancelButton.TabIndex = 1;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += Cancel_Click;
            // 
            // PercentDiscountLabel
            // 
            PercentDiscountLabel.AutoSize = true;
            PercentDiscountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            PercentDiscountLabel.Location = new Point(3, 9);
            PercentDiscountLabel.Name = "PercentDiscountLabel";
            PercentDiscountLabel.Size = new Size(106, 15);
            PercentDiscountLabel.TabIndex = 2;
            PercentDiscountLabel.Text = "Percent Discount:";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(3, 36);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(58, 15);
            CategoryLabel.TabIndex = 3;
            CategoryLabel.Text = "Category:";
            // 
            // DiscountCategoryComboBox
            // 
            DiscountCategoryComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DiscountCategoryComboBox.FormattingEnabled = true;
            DiscountCategoryComboBox.Location = new Point(67, 33);
            DiscountCategoryComboBox.Name = "DiscountCategoryComboBox";
            DiscountCategoryComboBox.Size = new Size(246, 23);
            DiscountCategoryComboBox.TabIndex = 4;
            // 
            // AddDiscountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 133);
            Controls.Add(DiscountCategoryComboBox);
            Controls.Add(CategoryLabel);
            Controls.Add(PercentDiscountLabel);
            Controls.Add(CancelButton);
            Controls.Add(OkButton);
            Name = "AddDiscountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OkButton;
        private Button CancelButton;
        private Label PercentDiscountLabel;
        private Label CategoryLabel;
        private ComboBox DiscountCategoryComboBox;
    }
}
