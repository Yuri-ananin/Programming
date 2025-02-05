using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contacts
{
    public partial class ThirdForm : Form
    {
        private Contact _contact;

        public ThirdForm(Contact contact)
        {
            InitializeComponent();
            _contact = contact;

            _contact.FullNameChanged += Contact_FullNameChanged;
            _contact.PhoneNumberChanged += Contact_PhoneNumberChanged;
            _contact.AddressChanged += Contact_AddressChanged;

            FullNameTextBox.Text = _contact.Fullname;
            PhoneNumberTextBox.Text = _contact.PhoneNumber;
            AddressTextBox.Text = _contact.Address;
        }

        private void Contact_FullNameChanged(object sender, EventArgs e)
        {
            FullNameTextBox.Text = _contact.Fullname;
        }

        private void Contact_PhoneNumberChanged(object sender, EventArgs e)
        {
            PhoneNumberTextBox.Text = _contact.PhoneNumber;
        }

        private void Contact_AddressChanged(object sender, EventArgs e)
        {
            AddressTextBox.Text = _contact.Address;
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_contact.Fullname != FullNameTextBox.Text)
            {
                _contact.Fullname = FullNameTextBox.Text;
            }
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_contact.PhoneNumber != PhoneNumberTextBox.Text)
            {
                _contact.PhoneNumber = PhoneNumberTextBox.Text;
            }
        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            if (_contact.Address != AddressTextBox.Text)
            {
                _contact.Address = AddressTextBox.Text;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
