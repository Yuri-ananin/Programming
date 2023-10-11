namespace ObjectOrientedPractics
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            itemsTab1 = new View.Tabs.ItemsTab();
            tabControl1 = new TabControl();
            ItemsPage = new TabPage();
            tabPage2 = new TabPage();
            customersTab1 = new View.Tabs.CustomersTab();
            tabControl1.SuspendLayout();
            ItemsPage.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(936, 571);
            itemsTab1.TabIndex = 0;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ItemsPage);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(950, 605);
            tabControl1.TabIndex = 1;
            // 
            // ItemsPage
            // 
            ItemsPage.Controls.Add(itemsTab1);
            ItemsPage.Location = new Point(4, 24);
            ItemsPage.Name = "ItemsPage";
            ItemsPage.Padding = new Padding(3);
            ItemsPage.Size = new Size(942, 577);
            ItemsPage.TabIndex = 0;
            ItemsPage.Text = "Items";
            ItemsPage.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(customersTab1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(942, 577);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(936, 571);
            customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 605);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(966, 644);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            tabControl1.ResumeLayout(false);
            ItemsPage.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private View.Tabs.ItemsTab itemsTab1;
        private TabControl tabControl1;
        private TabPage ItemsPage;
        private TabPage tabPage2;
        private View.Tabs.CustomersTab customersTab1;
    }
}