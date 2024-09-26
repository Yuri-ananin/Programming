using System.Data;
using ObjectOrientedPractics.View.Controls;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Forms;

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
        private int _selectedIndex = -1;

        /// <summary>
        /// Копия текущего покупателя.
        /// </summary>
        private Customer _cloneCurrentCustomer = new Customer();

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
            Sort();
            ClearCustomerInfo();
            CustomersListBox.SelectedIndex = -1;
            ToggleInputBoxes(false);
            
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
                    _currentCustomer = new Customer(FullNameTextBox.Text,
                   new Address(AddressControl.Address.Index, AddressControl.Address.Country,
                  AddressControl.Address.City, AddressControl.Address.Street,
                  AddressControl.Address.Building, AddressControl.Address.Apartment));
                    _currentCustomer.IsPriority = PriorityCheckBox.Checked;

                    DiscountsListBox.DataSource = null;
                    DiscountsListBox.DataSource = _cloneCurrentCustomer.Discounts;
                    DiscountsListBox.DisplayMember = "Info";

                    _customersList.Add(_currentCustomer);
                    Sort();
                    ClearCustomerInfo();
                    ToggleInputBoxes(false);
                    return;
                }
                else
                {
                    _customersList[_selectedIndex] = _cloneCurrentCustomer;
                    _currentCustomer = _cloneCurrentCustomer;
                }

                _selectedIndex = -1;
                Sort();
                ClearCustomerInfo();
                ToggleInputBoxes(false);
                UpdateCustomerInfo();
                CustomersListBox.ClearSelected();
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
                _cloneCurrentCustomer = (Customer)CustomersListBox.SelectedItem;
                _cloneCurrentCustomer = (Customer)_cloneCurrentCustomer.Clone();
                FullNameTextBox.Text = _cloneCurrentCustomer.Fullname;
                AddressControl.Address = (Address)_cloneCurrentCustomer.Address.Clone();
                IdTextBox.Text = _cloneCurrentCustomer.Id.ToString();
                PriorityCheckBox.Checked = _cloneCurrentCustomer.IsPriority;

                DiscountsListBox.DataSource = null;
                DiscountsListBox.DataSource = _cloneCurrentCustomer.Discounts;
                DiscountsListBox.DisplayMember = "Info";

                EditButton.Enabled = true;
                SaveButton.Enabled = false;
            }
            else
            {
                EditButton.Enabled = false;
            }
        }

        private void AddCustomerButton_Click(object sender, EventArgs e)
        {
            CustomersListBox.SelectedIndex = -1;
            _selectedIndex = -1;
            ClearCustomerInfo();
            ToggleInputBoxes(true);
            DiscountsPanel.Enabled = false;
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

        private void PriorityCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                _cloneCurrentCustomer.IsPriority = PriorityCheckBox.Checked;
            }
        }

        private void AddDiscountButton_Click(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                AddDiscountForm addDiscountForm = new AddDiscountForm();
                addDiscountForm.SelectedIndex = CustomersListBox.SelectedIndex;
                addDiscountForm.Customers = Customers;
                addDiscountForm.Show();
            }
        }

        private void RemoveDiscountButton_Click(object sender, EventArgs e)
        {
            if (DiscountsListBox.SelectedIndex > 0)
            {
                _cloneCurrentCustomer.Discounts.RemoveAt(DiscountsListBox.SelectedIndex);
            }
            DiscountsListBox.DataSource = null;
            DiscountsListBox.DataSource = _cloneCurrentCustomer.Discounts;
            DiscountsListBox.DisplayMember = "Info";
        }

        /// <summary>
        /// Очистка полей данных.
        /// </summary>
        private void ClearCustomerInfo()
        {
            AddressControl.AddressClear();
            FullNameTextBox.Clear();
            FullNameTextBox.BackColor = Color.White;
            IdTextBox.Clear();
            DiscountsListBox.DataSource = null;
            PriorityCheckBox.Enabled = false;
            SaveButton.Enabled = false;
        }

        /// <summary>
        /// Вкл. и выкл. полей данных.
        /// </summary>
        /// <param name="value">true or false</param>
        private void ToggleInputBoxes(bool value)
        {
            FullNameTextBox.Enabled = value;
            AddressControl.Enabled = value;
            SaveButton.Visible = value;
            PriorityCheckBox.Enabled = value;
            DiscountsPanel.Enabled = value;
        }

        /// <summary>
        /// Сортировка <see cref="CustomersListBox"/>.
        /// </summary>
        private void Sort()
        {
            var _indexBeforeSort = CustomersListBox.SelectedIndex;
            CustomersListBox.SelectedIndexChanged -= CustomersListBox_SelectedIndexChanged;
            _customersList = _customersList.OrderBy(customer => customer.ToString()).ToList();
            CustomersListBox.DataSource = _customersList;
            CustomersListBox.SelectedIndex = _indexBeforeSort;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Метод, который обновляет данные текущего выбранного покупателя.
        /// </summary>
        private void UpdateCustomerInfo()
        {
            FullNameTextBox.Text = _currentCustomer.Fullname.ToString();
            AddressControl.Address = _currentCustomer.Address;
            IdTextBox.Text = _currentCustomer.Id.ToString();
            PriorityCheckBox.Checked = _currentCustomer.IsPriority;
            DiscountsListBox.DataSource = null;
            DiscountsListBox.DataSource = _cloneCurrentCustomer.Discounts;
            DiscountsListBox.DisplayMember = "Info";

        }

        /// <summary>
        /// Проверка на правильный ввод всех полей.
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