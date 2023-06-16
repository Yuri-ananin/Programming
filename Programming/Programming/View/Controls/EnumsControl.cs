using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Controls
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий листбоксы с перечислением.
    /// </summary>
    public partial class EnumsControl : UserControl
    {
        public EnumsControl()
        {
            InitializeComponent();
            string[] enums = { "Colors", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" };
            EnumsListBox.DataSource = enums;
            EnumsListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            string enumerations = EnumsListBox.Text;
            Type type = Type.GetType(String.Format("Programming.Model.Enums.{0}", enumerations));
            var values = Enum.GetValues(type).Cast<object>().ToArray();
            ValuesListBox.Items.AddRange(values);
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = (int)ValuesListBox.SelectedItem;
            ValuesTextBox.Text = value.ToString();
        }

    }
}
