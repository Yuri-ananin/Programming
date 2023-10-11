using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Класс, описывающиq пользовательский элемент управления, содержащий страницу Customers.
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
        /// Название файла для записи данных.
        /// </summary>
        private string _fileName = "Customers.Json";

        public CustomersTab()
        {
            InitializeComponent();
            LoadCustomersInfo();
            IdTextBox.Enabled = false;
            ToggleInputBoxes(false);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FullNameTextBox.Text) ||
                string.IsNullOrEmpty(AddressTextBox.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка ввода");
                return;
            }

            if (_selectedIndex == -1)
            {
                _currentCustomer = new Model.Customer(
                    FullNameTextBox.Text,
                    AddressTextBox.Text);
                _customersList.Add(_currentCustomer);
                Sort();
                SaveCustomer();
                ToggleInputBoxes(false);
                return;
            }
            else
            {
                _customersList[_selectedIndex] = _cloneCurrentCustomer;
                _currentCustomer = _cloneCurrentCustomer;
            }

            Sort();
            SaveCustomer();
            ToggleInputBoxes(false);
            UpdateCustomerInfo();
            CustomersListBox.ClearSelected();
            ClearCustomerInfo();
        }

        private void CustomersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersListBox.SelectedIndex != -1)
            {
                ToggleInputBoxes(false);
                _cloneCurrentCustomer = (Customer)_customersList[CustomersListBox.SelectedIndex].Clone();
                FullNameTextBox.Text = _cloneCurrentCustomer.Fullname.ToString();
                AddressTextBox.Text = _cloneCurrentCustomer.Address.ToString();
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
            _cloneCurrentCustomer = (Model.Customer)_customersList[_selectedIndex].Clone();
            ToggleInputBoxes(true);
            SaveButton.Visible = true;
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

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(AddressTextBox.Text))
                {
                    _cloneCurrentCustomer.Address = AddressTextBox.Text;
                    AddressTextBox.BackColor = Color.White;
                    _isValidAddress = true;
                    CheckData();
                    return;
                }

                else
                {
                    AddressTextBox.BackColor = Color.LightPink;
                    _isValidAddress = false;
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                AddressTextBox.BackColor = Color.LightPink;
                _isValidAddress = false;
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
            SaveCustomer();
            Sort();
            ClearCustomerInfo();
        }

        /// <summary>
        /// Метод, который очищает все TextBox.
        /// </summary>
        private void ClearCustomerInfo()
        {

            FullNameTextBox.Text = string.Empty;
            FullNameTextBox.BackColor = Color.White;
            AddressTextBox.Text = string.Empty;
            AddressTextBox.BackColor = Color.White;
            IdTextBox.Text = string.Empty;
        }

        /// <summary>
        /// Метод, который отключает или включает все TextBox.
        /// </summary>
        /// <param name="value">True or false.</param>
        private void ToggleInputBoxes(bool value)
        {
            FullNameTextBox.Enabled = value;
            AddressTextBox.Enabled = value;
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
            _customersList = _customersList.OrderBy(song => song.ToString()).ToList();
            CustomersListBox.DataSource = _customersList;
            CustomersListBox.SelectedIndex = _indexBeforeSort;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
        }

        /// <summary>
        /// Метод для сохранения данных в json файл.
        /// </summary>
        public void SaveCustomer()
        {
            if (CustomersListBox.Items.Count != 0)
            {
                var jsonString = System.Text.Json.JsonSerializer.Serialize(_customersList);
                File.WriteAllText("Customers.json", jsonString);
            }
        }

        /// <summary>
        /// Метод, которых загружает сохраненные данные.
        /// </summary>
        private void LoadCustomersInfo()
        {
            if (File.Exists(_fileName))
            {
                _customersList = JsonConvert.DeserializeObject<List<Customer>>(File.ReadAllText(_fileName));
                Sort();
            }
        }

        /// <summary>
        /// Метод, который обновляет данные текущего выбранного покупателя в TextBox.
        /// </summary>
        private void UpdateCustomerInfo()
        {
            FullNameTextBox.Text = _currentCustomer.Fullname.ToString();
            AddressTextBox.Text = _currentCustomer.Address.ToString();
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
