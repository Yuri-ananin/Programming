namespace Programming
{
    partial class MainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Classes = new System.Windows.Forms.TabPage();
            this.filmsControl1 = new Programming.View.Controls.FilmsControl();
            this.rectanglesControl1 = new Programming.View.Controls.RectanglesControl();
            this.EnumsTabPage = new System.Windows.Forms.TabPage();
            this.SeasonHandleControl = new Programming.View.Controls.SeasonHandleControl();
            this.weekdayParsingControl1 = new Programming.View.Controls.WeekdayParsingControl();
            this.enumsControl1 = new Programming.View.Controls.EnumsControl();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programming.View.Controls.RectanglesCollisionControl();
            this.Classes.SuspendLayout();
            this.EnumsTabPage.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Classes
            // 
            this.Classes.Controls.Add(this.filmsControl1);
            this.Classes.Controls.Add(this.rectanglesControl1);
            this.Classes.Location = new System.Drawing.Point(4, 22);
            this.Classes.Name = "Classes";
            this.Classes.Padding = new System.Windows.Forms.Padding(3);
            this.Classes.Size = new System.Drawing.Size(575, 478);
            this.Classes.TabIndex = 1;
            this.Classes.Text = "Classes";
            this.Classes.UseVisualStyleBackColor = true;
            // 
            // filmsControl1
            // 
            this.filmsControl1.Location = new System.Drawing.Point(282, 0);
            this.filmsControl1.Name = "filmsControl1";
            this.filmsControl1.Size = new System.Drawing.Size(290, 330);
            this.filmsControl1.TabIndex = 19;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(3, 0);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(276, 330);
            this.rectanglesControl1.TabIndex = 18;
            // 
            // EnumsTabPage
            // 
            this.EnumsTabPage.Controls.Add(this.SeasonHandleControl);
            this.EnumsTabPage.Controls.Add(this.weekdayParsingControl1);
            this.EnumsTabPage.Controls.Add(this.enumsControl1);
            this.EnumsTabPage.Location = new System.Drawing.Point(4, 22);
            this.EnumsTabPage.Name = "EnumsTabPage";
            this.EnumsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.EnumsTabPage.Size = new System.Drawing.Size(575, 478);
            this.EnumsTabPage.TabIndex = 0;
            this.EnumsTabPage.Text = "Enums";
            this.EnumsTabPage.UseVisualStyleBackColor = true;
            // 
            // SeasonHandleControl
            // 
            this.SeasonHandleControl.Location = new System.Drawing.Point(280, 368);
            this.SeasonHandleControl.Name = "SeasonHandleControl";
            this.SeasonHandleControl.Size = new System.Drawing.Size(292, 107);
            this.SeasonHandleControl.TabIndex = 13;
            // 
            // weekdayParsingControl1
            // 
            this.weekdayParsingControl1.Location = new System.Drawing.Point(-4, 361);
            this.weekdayParsingControl1.Name = "weekdayParsingControl1";
            this.weekdayParsingControl1.Size = new System.Drawing.Size(278, 114);
            this.weekdayParsingControl1.TabIndex = 12;
            // 
            // enumsControl1
            // 
            this.enumsControl1.Location = new System.Drawing.Point(-4, 3);
            this.enumsControl1.Name = "enumsControl1";
            this.enumsControl1.Size = new System.Drawing.Size(576, 359);
            this.enumsControl1.TabIndex = 11;
            // 
            // MainTabControl
            // 
            this.MainTabControl.Controls.Add(this.EnumsTabPage);
            this.MainTabControl.Controls.Add(this.Classes);
            this.MainTabControl.Controls.Add(this.tabPage1);
            this.MainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            this.MainTabControl.Size = new System.Drawing.Size(583, 504);
            this.MainTabControl.TabIndex = 0;
            this.MainTabControl.Tag = "Rectangles";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rectanglesCollisionControl1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(575, 478);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Rectangles";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(3, 3);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(569, 472);
            this.rectanglesCollisionControl1.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 504);
            this.Controls.Add(this.MainTabControl);
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Programming Demo";
            this.Classes.ResumeLayout(false);
            this.EnumsTabPage.ResumeLayout(false);
            this.MainTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage Classes;
        private System.Windows.Forms.TabPage EnumsTabPage;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private View.Controls.RectanglesCollisionControl rectanglesCollisionControl1;
        private View.Controls.EnumsControl enumsControl1;
        private View.Controls.WeekdayParsingControl weekdayParsingControl1;
        private View.Controls.SeasonHandleControl SeasonHandleControl;
        private View.Controls.RectanglesControl rectanglesControl1;
        private View.Controls.FilmsControl filmsControl1;


    }
}

