using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;

namespace Programming.View.Controls
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий SeasonHandleGroupBox.
    /// </summary>
    public partial class SeasonHandleControl : UserControl
    {
        public SeasonHandleControl()
        {
            InitializeComponent();
            SeasonHandleComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonHandleComboBox.SelectedIndex = 0;
        }

        private void SeasonHandleButton_Click(object sender, EventArgs e)
        {
            string names = Enum.GetNames(typeof(Season)).ToString();
            SeasonHandleGroupBox.BackColor = Color.White;
            SeasonHandleLabel.Text = names;
            switch (Enum.Parse(typeof(Season), SeasonHandleComboBox.Text).ToString())
            {
                case "Winter":
                    {
                        SeasonHandleLabel.Text = "Бррр! Холодно!";
                        break;
                    }
                case "Summer":
                    {
                        SeasonHandleLabel.Text = "Ура! Солнце!";
                        break;
                    }
                case "Autumn":
                    {
                        SeasonHandleGroupBox.BackColor = ColorTranslator.FromHtml("#e29c45");
                        break;
                    }
                case "Spring":
                    {
                        SeasonHandleGroupBox.BackColor = ColorTranslator.FromHtml("#559c45");
                        break;
                    }
            }
        }

    }
}
