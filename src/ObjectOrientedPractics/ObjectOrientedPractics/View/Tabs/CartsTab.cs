using ObjectOrientedPractics.Model;
using System.ComponentModel;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class CartsTab : UserControl
    {
        /// <summary>
        /// Задает список товаров.
        /// </summary>
        internal List<Item> Items
        {
            set
            {
                ItemsListBox.DataSource = null;
                ItemsListBox.DataSource = value;
            }
        }

        /// <summary>
        /// Задает список заказчиков.
        /// </summary>
        internal List<Customer> Customers
        {
            set
            {
                CustomersComboBox.DataSource = null;
                CustomersComboBox.DataSource = value;
            }
        }

        /// <summary>
        /// Текущий заказчик.
        /// </summary>
        private Customer _currentCustomer = new Customer();

        /// <summary>
        /// Список товаров в корзине.
        /// </summary>
        private BindingList<Item> _currentItems;

        public CartsTab()
        {
            InitializeComponent();
            CartListBox.DataSource = _currentItems;
            CustomersComboBox.SelectedIndex = -1;
        }

        private void CustomerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                _currentCustomer = (Customer)CustomersComboBox.SelectedItem;
                if (_currentCustomer.Cart.Items == null)
                {
                    _currentItems = new BindingList<Item>();
                }
                else
                {
                    _currentItems = new BindingList<Item>(_currentCustomer.Cart.Items);
                }
                _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
                PriceLabel.Text = _currentCustomer.Cart.Amount.ToString();
                CartListBox.DataSource = _currentItems;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1 && CustomersComboBox.SelectedIndex != -1)
            {
                _currentItems.Add((Item)ItemsListBox.SelectedItem);
                _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
                PriceLabel.Text = _currentCustomer.Cart.Amount.ToString();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex != -1 && CustomersComboBox.SelectedIndex != -1)
            {
                _currentItems.Remove((Item)CartListBox.SelectedItem);
                _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
                PriceLabel.Text = _currentCustomer.Cart.Amount.ToString();
            }
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            if (CustomersComboBox.SelectedIndex != -1)
            {
                if (CartListBox.Items.Count == 0)
                {
                    return;
                }

                if (_currentCustomer.IsPriority == false)
                {
                    _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
                    _currentCustomer.Orders.Add(new Order(_currentCustomer.Address, _currentCustomer.Cart, OrderStatus.New, DateTime.Now.ToString()));
                    _currentItems = new BindingList<Item>(); ;
                    ClearOrder();
                }

                else
                {
                    _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
                    _currentCustomer.Orders.Add(new PriorityOrder(_currentCustomer.Address, _currentCustomer.Cart, OrderStatus.New, DateTime.Now.ToString()));
                    _currentItems = new BindingList<Item>(); ;
                    ClearOrder();
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearOrder();
            CartListBox.DataSource = null;
        }

        /// <summary>
        /// Очистка корзины.
        /// </summary>
        private void ClearOrder()
        {
            _currentItems = new BindingList<Item>();
            CartListBox.DataSource = null;
            PriceLabel.Text = "0.0";
        }
    }
}
