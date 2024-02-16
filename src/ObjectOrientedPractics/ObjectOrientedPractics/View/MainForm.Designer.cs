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
            tabPage2 = new TabPage();
            CustomersTab = new View.Tabs.CustomersTab();
            ItemsPage = new TabPage();
            ItemsTab = new View.Tabs.ItemsTab();
            TabControl = new TabControl();
            CartsPage = new TabPage();
            CartsTab = new View.Tabs.CartsTab();
            tabPage1 = new TabPage();
            OrdersTab = new View.Tabs.OrdersTab();
            tabPage2.SuspendLayout();
            ItemsPage.SuspendLayout();
            TabControl.SuspendLayout();
            CartsPage.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(CustomersTab);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(942, 577);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Customers";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // CustomersTab
            // 
            CustomersTab.Dock = DockStyle.Fill;
            CustomersTab.Location = new Point(3, 3);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Size = new Size(936, 571);
            CustomersTab.TabIndex = 0;
            // 
            // ItemsPage
            // 
            ItemsPage.Controls.Add(ItemsTab);
            ItemsPage.Location = new Point(4, 24);
            ItemsPage.Name = "ItemsPage";
            ItemsPage.Padding = new Padding(3);
            ItemsPage.Size = new Size(942, 577);
            ItemsPage.TabIndex = 0;
            ItemsPage.Text = "Items";
            ItemsPage.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            ItemsTab.Dock = DockStyle.Fill;
            ItemsTab.Location = new Point(3, 3);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Size = new Size(936, 571);
            ItemsTab.TabIndex = 0;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(ItemsPage);
            TabControl.Controls.Add(tabPage2);
            TabControl.Controls.Add(CartsPage);
            TabControl.Controls.Add(tabPage1);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 0);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(950, 605);
            TabControl.TabIndex = 1;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            TabControl.TabIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // CartsPage
            // 
            CartsPage.Controls.Add(CartsTab);
            CartsPage.Location = new Point(4, 24);
            CartsPage.Name = "CartsPage";
            CartsPage.Padding = new Padding(3);
            CartsPage.Size = new Size(942, 577);
            CartsPage.TabIndex = 2;
            CartsPage.Text = "Carts";
            CartsPage.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            CartsTab.Dock = DockStyle.Fill;
            CartsTab.Location = new Point(3, 3);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(936, 571);
            CartsTab.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(OrdersTab);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(942, 577);
            tabPage1.TabIndex = 3;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // OrdersTab
            // 
            OrdersTab.Dock = DockStyle.Fill;
            OrdersTab.Location = new Point(3, 3);
            OrdersTab.Name = "OrdersTab";
            OrdersTab.Size = new Size(936, 571);
            OrdersTab.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 605);
            Controls.Add(TabControl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(966, 644);
            Name = "MainForm";
            Text = "Object Oriented Practics";
            FormClosing += MainForm_FormClosing;
            tabPage2.ResumeLayout(false);
            ItemsPage.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            CartsPage.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPage2;
        private View.Tabs.CustomersTab CustomersTab;
        private TabPage ItemsPage;
        private View.Tabs.ItemsTab ItemsTab;
        private TabControl TabControl;
        private TabPage CartsPage;
        private View.Tabs.CartsTab CartsTab;
        private TabPage tabPage1;
        private View.Tabs.OrdersTab OrdersTab;
    }
}