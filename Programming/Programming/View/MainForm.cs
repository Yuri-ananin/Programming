using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Enums;
using System.Windows.Forms;
using System.Reflection;

namespace Programming
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            string[] enums = { "Colors", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" };
            EnumsListBox.DataSource = enums;
            EnumsListBox.SelectedIndex = 0;
            SeasonHandleComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonHandleComboBox.SelectedIndex = 0;
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

        private void SeasonHandleButton_Click(object sender, EventArgs e)
        {
            SeasonHandleGroupBox.BackColor = Color.White;
            SeasonHandleLabel.Text = " ";
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