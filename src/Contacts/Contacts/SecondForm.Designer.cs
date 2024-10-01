namespace Contacts
{
    partial class SecondForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            PhoneNumberTextBox = new TextBox();
            FullNameTextBox = new TextBox();
            CloseButton = new Button();
            AddressTextBox = new TextBox();
            AddressLabel = new Label();
            PhoneNumberLabel = new Label();
            FullNameLabel = new Label();
            SuspendLayout();
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(12, 88);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(239, 23);
            PhoneNumberTextBox.TabIndex = 15;
            PhoneNumberTextBox.TextChanged += PhoneNumberTextBox_TextChanged;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(12, 33);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(239, 23);
            FullNameTextBox.TabIndex = 14;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(179, 233);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(75, 23);
            CloseButton.TabIndex = 13;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(11, 143);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(243, 23);
            AddressTextBox.TabIndex = 12;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(12, 126);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(52, 15);
            AddressLabel.TabIndex = 11;
            AddressLabel.Text = "Address:";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(12, 70);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(91, 15);
            PhoneNumberLabel.TabIndex = 10;
            PhoneNumberLabel.Text = "Phone Number:";
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(12, 15);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 9;
            FullNameLabel.Text = "Full Name:";
            // 
            // SecondForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 271);
            Controls.Add(PhoneNumberTextBox);
            Controls.Add(FullNameTextBox);
            Controls.Add(CloseButton);
            Controls.Add(AddressTextBox);
            Controls.Add(AddressLabel);
            Controls.Add(PhoneNumberLabel);
            Controls.Add(FullNameLabel);
            Name = "SecondForm";
            Text = "SecondForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PhoneNumberTextBox;
        private TextBox FullNameTextBox;
        private Button CloseButton;
        private TextBox AddressTextBox;
        private Label AddressLabel;
        private Label PhoneNumberLabel;
        private Label FullNameLabel;
    }
}