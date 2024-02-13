using System.Data;
using ObjectOrientedPractics.View.Controls;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Класс, описывающий покупателей.
    /// </summary>
    public partial class CustomersTab : UserControl
    {
        /// <summary>
        /// Список с данными о покупателях.
        /// </summary>
        private List<Customer> _customersList = new List<Customer>();

        /// <summary>
        /// Список с данными о текущем выбранном покупателе.
        /// </summary>
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Индекс текущего выбранного элемента.
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Индекс текущего выбранного элемента перед сортировкой.
        /// </summary>
        private int _indexBeforeSort;

        /// <summary>
        /// Копия текущего покупателя.
        /// </summary>
        private Customer _cloneCurrentCustomer = new();

        /// <summary>
        /// Правильность ввода Полного Имени покупателя.
        /// </summary>
        private bool _isValidFullName = true;

        /// <summary>
        /// Правильность ввода адреса для доставки покупателя.
        /// </summary>
        private bool _isValidAddress = true;

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        internal List<Customer> Customers
        {
            get
            {
                return _customersList;
            }
            set
            {
                _customersList = value;
                Sort();
            }
        }

        public CustomersTab()
        {
            InitializeComponent();
            IdTextBox.Enabled = false;
            ToggleInputBoxes(false);
            AddressControl.Address = _currentCustomer.Address;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameTextBox.Text) ||
                AddressControl.AddressIsNullOrEmpty())
            {
                MessageBox.Show("Заполните все поля.", "Ошибка ввода");
                return;
            }

            if (_isValidFullName == true && AddressControl.IsValidAddress())
            {
                if (_selectedIndex == -1)
                {
                    Address address = new Address(AddressControl.Address.Index,
                    AddressControl.Address.Country,
                  AddressControl.Address.City, AddressControl.Address.Street,
                  AddressControl.Address.Building, AddressControl.Address.Apartment);
                    _currentCustomer = new Customer(FullNameTextBox.Text, address);
                    _customersList.Add(_currentCustomer);
                    Sort();
                    ToggleInputBoxes(false);
                    return;
                }
                else
                {
                    _customersList[_selectedIndex] = _cloneCurrentCustomer;
                    _currentCustomer = _cloneCurrentCustomer;
                }

                Sort();
                ToggleInputBoxes(false);
                UpdateCustomerInfo();
                CustomersListBox.ClearSelected();
                ClearCustomerInfo();
            }
            else
            {
                MessageBox.Show("Введены некорректные значения", "Ошибка сохранения");
                return;
            }

        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                ToggleInputBoxes(false);
                _cloneCurrentCustomer = (Customer)_customersList[CustomersListBox.SelectedIndex].Clone();
                FullNameTextBox.Text = _cloneCurrentCustomer.Fullname.ToString();
                AddressControl.Address = _cloneCurrentCustomer.Address;
                IdTextBox.Text = _cloneCurrentCustomer.Id.ToString();
                SaveButton.Enabled = false;
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            ClearCustomerInfo();
            CustomersListBox.SelectedIndex = -1;
            _selectedIndex = -1;
            ToggleInputBoxes(true);
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0 || CustomersListBox.SelectedIndex == -1)
            {
                return;
            }

            _selectedIndex = CustomersListBox.SelectedIndex;
            _cloneCurrentCustomer = (Customer)_customersList[_selectedIndex].Clone();
            ToggleInputBoxes(true);
            SaveButton.Visible = true;
            SaveButton.Enabled = true;
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(FullNameTextBox.Text))
                {
                    _cloneCurrentCustomer.Fullname = FullNameTextBox.Text;
                    FullNameTextBox.BackColor = Color.White;
                    _isValidFullName = true;
                    CheckData();
                    return;
                }

                else
                {
                    FullNameTextBox.BackColor = Color.LightPink;
                    _isValidFullName = false;
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                FullNameTextBox.BackColor = Color.LightPink;
                _isValidFullName = false;
                CheckData();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.Items.Count == 0 || CustomersListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentCustomer = _customersList[CustomersListBox.SelectedIndex];
            _customersList.Remove(_currentCustomer);
            CustomersListBox.SelectedIndex = -1;
            Sort();
            ClearCustomerInfo();
        }

        /// <summary>
        /// Метод, который очищает все TextBox.
        /// </summary>
        private void ClearCustomerInfo()
        {
            AddressControl.AddressClear();
            FullNameTextBox.Clear();
            FullNameTextBox.BackColor = Color.White;
            IdTextBox.Clear();
            SaveButton.Enabled = false;
        }

        /// <summary>
        /// Метод, который отключает или включает все TextBox.
        /// </summary>
        /// <param name="value">True or false.</param>
        private void ToggleInputBoxes(bool value)
        {
            FullNameTextBox.Enabled = value;
            AddressControl.Enabled = value;
            SaveButton.Visible = value;
        }

        /// <summary>
        /// Метод, который сортирует <see cref= "_customersList" /> и < see cref= "CustomersListBox" />
        /// и загружает данные из <see cref="_customersList"/> в <see cref = "CustomersListBox" />.
        /// </summary>
        private void Sort()
        {
            _indexBeforeSort = CustomersListBox.SelectedIndex;
            CustomersListBox.SelectedIndexChanged -= CustomersListBox_SelectedIndexChanged;
            _customersList = _customersList.OrderBy((Customer) => Customer.ToString()).ToList();
            CustomersListBox.DataSource = _customersList;
            CustomersListBox.SelectedIndex = _indexBeforeSort;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Метод, который обновляет данные текущего выбранного покупателя в TextBox.
        /// </summary>
        private void UpdateCustomerInfo()
        {
            FullNameTextBox.Text = _currentCustomer.Fullname.ToString();
            AddressControl.Address = _currentCustomer.Address;
        }

        /// <summary>
        /// Метод, который проверяет значения текстовых полей 
        /// и не даёт сохранить их в случае неправильного ввода. 
        /// </summary>
        private void CheckData()
        {
            if (_isValidFullName && _isValidAddress)
            {
                SaveButton.Enabled = true;
            }
            else
            {
                SaveButton.Enabled = false;
            }
        }
    }
}