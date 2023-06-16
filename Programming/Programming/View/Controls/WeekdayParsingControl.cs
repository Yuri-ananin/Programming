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
    /// Класс, описывающий пользовательский элемент управления, содержащий WeekdayParsingGroupBox.
    /// </summary>
    public partial class WeekdayParsingControl : UserControl
    {
        public WeekdayParsingControl()
        {
            InitializeComponent();
        }

        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            {
                Weekday text;
                if (Enum.TryParse(WeekdayParsingTextBox.Text, out text))
                {
                    WeekdayParsingLabel.Text = String.Format("Это день недели ({0} = {1})", text, (int)text + 1);
                }
                else
                {
                    WeekdayParsingLabel.Text = "Нет такого дня недели";
                }
            }
        }

    }
}
