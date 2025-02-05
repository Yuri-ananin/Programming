namespace Contacts
{
    public partial class FirstForm : Form
    {
        private Contact _contact;
        private SecondForm _secondForm;
        private ThirdForm _thirdForm;
        public FirstForm()
        {
            InitializeComponent();

            _contact = new Contact
            {
                Fullname = "John Doe",
                PhoneNumber = "123456789",
                Address = "123 Main St"
            };

            _secondForm = new SecondForm(_contact);
            _thirdForm = new ThirdForm(_contact);

            _secondForm.Show();
            _thirdForm.Show();

 
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