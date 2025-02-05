namespace Contacts
{
    partial class FirstForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FullNameLabel = new Label();
            PhoneNumberLabel = new Label();
            AddressLabel = new Label();
            AddressTextBox = new TextBox();
            CloseButton = new Button();
            FullNameTextBox = new TextBox();
            PhoneNumberTextBox = new TextBox();
            SuspendLayout();
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(13, 26);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 0;
            FullNameLabel.Text = "Full Name:";
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Location = new Point(13, 81);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(91, 15);
            PhoneNumberLabel.TabIndex = 1;
            PhoneNumberLabel.Text = "Phone Number:";
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Location = new Point(13, 137);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(52, 15);
            AddressLabel.TabIndex = 2;
            AddressLabel.Text = "Address:";
            // 
            // AddressTextBox
            // 
            AddressTextBox.Location = new Point(12, 154);
            AddressTextBox.Name = "AddressTextBox";
            AddressTextBox.Size = new Size(243, 23);
            AddressTextBox.TabIndex = 5;
            AddressTextBox.TextChanged += AddressTextBox_TextChanged;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(180, 244);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(75, 23);
            CloseButton.TabIndex = 6;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.Location = new Point(13, 44);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(239, 23);
            FullNameTextBox.TabIndex = 7;
            FullNameTextBox.TextChanged += FullNameTextBox_TextChanged;
            // 
            // PhoneNumberTextBox
            // 
            PhoneNumberTextBox.Location = new Point(13, 99);
            PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            PhoneNumberTextBox.Size = new Size(239, 23);
            PhoneNumberTextBox.TabIndex = 8;
            PhoneNumberTextBox.TextChanged += PhoneNumberTextBox_TextChanged;
            // 
            // FirstForm
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
            Name = "FirstForm";
            Text = "Main Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label FullNameLabel;
        private Label PhoneNumberLabel;
        private Label AddressLabel;

        private TextBox AddressTextBox;
        private Button CloseButton;
        private TextBox FullNameTextBox;
        private TextBox PhoneNumberTextBox;
    }
}