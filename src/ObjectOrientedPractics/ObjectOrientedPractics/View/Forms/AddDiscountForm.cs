using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Discounts;
using ObjectOrientedPractics.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.View.Tabs;

namespace ObjectOrientedPractics.View.Forms
{
    public partial class AddDiscountForm : Form
    {
        /// <summary>
        /// Возвращает и задает выбранный индекс покупателя в CustomersListBox.
        /// </summary>
        public int SelectedIndex { get; set; }

        /// <summary>
        /// Возвращает и задает список покупателей.
        /// </summary>
        internal List<Customer> Customers { get; set; }

        public AddDiscountForm()
        {
            InitializeComponent();
            DiscountCategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
            DiscountCategoryComboBox.SelectedIndex = -1;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (DiscountCategoryComboBox.SelectedIndex != -1)
            {
                Category selectedCategory = (Category)DiscountCategoryComboBox.SelectedItem;

                var existingDiscount = Customers[SelectedIndex].Discounts
                    .OfType<PercentDiscount>()
                    .FirstOrDefault(d => d.DiscountCategory == selectedCategory);

                if (existingDiscount != null)
                {
                    existingDiscount.CurrentDiscount += 0.01; 
                }
                else
                { 
                    PercentDiscount newPercentDiscount = new PercentDiscount
                    {
                        DiscountCategory = selectedCategory
                    };
                    Customers[SelectedIndex].Discounts.Add(newPercentDiscount);
                }
                Close();
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
