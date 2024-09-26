using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using System.ComponentModel;
using ObjectOrientedPractics.Model.Orders;
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

                DiscountsCheckedListBox.DataSource = _currentCustomer.Discounts;
                DiscountsCheckedListBox.DisplayMember = "Info";

                for (int i = 0; i < DiscountsCheckedListBox.Items.Count; i++)
                {
                    DiscountsCheckedListBox.SetItemChecked(i, true);
                }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1 && CustomersComboBox.SelectedIndex != -1)
            {
                _currentItems.Add((Item)ItemsListBox.SelectedItem);
                _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
                PriceLabel.Text = _currentCustomer.Cart.Amount.ToString();
                RefreshDiscount();
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (CartListBox.SelectedIndex != -1 && CustomersComboBox.SelectedIndex != -1)
            {
                _currentItems.Remove((Item)CartListBox.SelectedItem);
                _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
                PriceLabel.Text = _currentCustomer.Cart.Amount.ToString();
                CartListBox.Refresh();
                RefreshDiscount();
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
                    Order order = new Order(_currentCustomer.Address, _currentCustomer.Cart, OrderStatus.New, DateTime.Now.ToString());
                    order.DiscountAmount = ApplyDiscount();
                    order.Amount = order.Amount - order.DiscountAmount;
                    _currentCustomer.Orders.Add(order);
                    ClearOrder();
                }

                else
                {
                    _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
                    Order order = new PriorityOrder(_currentCustomer.Address, _currentCustomer.Cart, OrderStatus.New, DateTime.Now.ToString());
                    order.DiscountAmount = ApplyDiscount();
                    order.Amount = order.Amount - order.DiscountAmount;
                    _currentCustomer.Orders.Add(order);
                    ClearOrder();
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearOrder();
            CartListBox.DataSource = null;
        }

        private void DiscountsCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentCustomer.Discounts != null)
            {
                RefreshDiscount();
            }
        }

        /// <summary>
        /// Очистка корзины.
        /// </summary>
        private void ClearOrder()
        {
            _currentItems = new BindingList<Item>();
            _currentCustomer.Cart.Items = _currentItems.ToList<Item>();
            CartListBox.DataSource = null;
            RefreshDiscount();
            PriceLabel.Text = "0";

            DiscountsCheckedListBox.ClearSelected();
        }

        /// <summary>
        /// Метод, который считает размер скидки.
        /// </summary>
        private void RefreshDiscount()
        {
            double discountAmount = 0;
            for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
            {
                discountAmount += _currentCustomer.Discounts[i].Calculate(_currentCustomer.Cart.Items);

                if (!DiscountsCheckedListBox.GetItemChecked(i))
                {
                    discountAmount -= _currentCustomer.Discounts[i].Calculate(_currentCustomer.Cart.Items);
                }
            }
            AmountDiscountLabel.Text = discountAmount.ToString();
            TotalCostLabel.Text = (_currentCustomer.Cart.Amount - discountAmount).ToString();
        }
        
        /// <summary>
        /// Метод, который применяет скидку к товарам.
        /// </summary>
        /// <returns>Размер скидки.</returns>
        private double ApplyDiscount()
        {
            double discountAmount = 0;
            for (int i = 0; i < _currentCustomer.Discounts.Count; i++)
            {
                if (DiscountsCheckedListBox.GetItemChecked(i))
                {
                    discountAmount += _currentCustomer.Discounts[i].Apply(_currentCustomer.Cart.Items);
                    _currentCustomer.Discounts[i].Update(_currentCustomer.Cart.Items);
                }
            }
            return discountAmount;
        }
    }
}
