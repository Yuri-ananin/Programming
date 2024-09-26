using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class OrdersTab : UserControl
    {
        /// <summary>
        /// Список покупателей.
        /// </summary>
        private List<Customer> _customers;

        /// <summary>
        /// Список покупателей с заказами.
        /// </summary>
        private List<Order> _ordersList;

        /// <summary>
        /// Текущий покупатель.
        /// </summary>
        private Customer _currentCustomer;

        /// <summary>
        /// Текущий приоритетный заказ.
        /// </summary>
        private PriorityOrder _selectedPriorityOrder = new PriorityOrder();

        /// <summary>
        /// Возвращает и задаёт список покупателей. Также создаёт список покупателей с заказами.
        /// </summary>
        internal List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _ordersList = new List<Order>();
                _customers = value;

                OrdersDataGridView.DataSource = null;
                OrdersDataGridView.Rows.Clear();
                foreach (Customer customer in Customers)
                {
                    if (customer.Orders != null)
                    {
                        foreach (Order order in customer.Orders)
                        {
                            if (order != null)
                            {
                                string[] currentOrder = {$"{order.Id}", $"{order.Date}", $"{customer.Fullname}", $"{order.Address}",
                                $"{order.OrderStatus}", $"{order.Amount}"};
                                OrdersDataGridView.Rows.Add(currentOrder);

                                OrdersDataGridView.Refresh();
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Статус заказа.
        /// </summary>
        object[] _categoryvalues = Enum.GetValues(typeof(OrderStatus)).Cast<object>().ToArray();

        public OrdersTab()
        {
            InitializeComponent();

            for (int i = 0; i < Enum.GetNames(typeof(DesiredDeliveryTime)).Length; i++)
            {
                var enumType = typeof(DesiredDeliveryTime);
                var memberInfos =
                enumType.GetMember(Enum.Parse(typeof(DesiredDeliveryTime), i.ToString()).ToString());
                var enumValueMemberInfo = memberInfos.FirstOrDefault(m => m.DeclaringType == enumType);
                var valueAttributes = enumValueMemberInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                var description = ((DescriptionAttribute)valueAttributes[0]).Description;
                DeliveryTimeComboBox.Items.Add(description);
            }

            DeliveryTimeComboBox.SelectedIndex = 0;

            StatusComboBox.Items.AddRange(_categoryvalues);
            StatusComboBox.SelectedItem = _categoryvalues[0];
        }

        private void OrdersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (OrdersDataGridView.CurrentCell.RowIndex == -1)
            {
                return;
            }

            foreach (Customer customer in Customers)
            {
                if (customer.Orders != null)
                {
                    foreach (Order order in customer.Orders)
                    {
                        if (order != null &&
                            order.Id == int.Parse((String)OrdersDataGridView.Rows[OrdersDataGridView.CurrentCell.RowIndex].Cells[0].Value))
                        {
                            _currentCustomer = customer;
                            IdTextBox.Text = _currentCustomer.Id.ToString();
                            CreatedTextBox.Text = order.Date;
                            StatusComboBox.SelectedIndex = ((int)order.OrderStatus);
                            DeliveryAddressControl.Address = _currentCustomer.Address;
                            OrderItemsListBox.DataSource = order.Items;
                            AmountCostLabel.Text = order.Amount.ToString();

                            if (order is PriorityOrder)
                            {
                                DeliveryTimeComboBox.SelectedIndex = (int)((PriorityOrder)order).DesiredDeliveryTime;
                            }


                            if (order.GetType() == typeof(Order))
                            {
                                _selectedPriorityOrder = null;
                                PriorityOptionsPanel.Visible = false;
                            }
                            else
                            {
                                _selectedPriorityOrder = new PriorityOrder(order.Address, customer.Cart, OrderStatus.New, DateTime.Now.ToString());
                                PriorityOptionsPanel.Visible = true;
                            }
                        }
                    }
                }
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatusComboBox.SelectedIndex != -1 & _currentCustomer != null)
            {
                foreach (Customer customer in Customers)
                {
                    if (customer.Orders != null)
                    {
                        foreach (Order order in customer.Orders)
                        {
                            if (order != null &&
                                order.Id == int.Parse((String)OrdersDataGridView.Rows[OrdersDataGridView.CurrentCell.RowIndex].Cells[0].Value))
                            {
                                order.OrderStatus = (OrderStatus)StatusComboBox.SelectedItem;
                                string[] currentOrder = {$"{order.Id}", $"{order.Date}", $"{customer.Fullname}", $"{order.Address}",
                                $"{order.OrderStatus}", $"{order.Amount}"};
                                OrdersDataGridView.Rows[OrdersDataGridView.CurrentCell.RowIndex].SetValues(currentOrder);
                                OrdersDataGridView.Refresh();
                            }
                        }
                    }
                }
            }
        }

        private void DeliveryTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectedPriorityOrder.DesiredDeliveryTime = (DesiredDeliveryTime)DeliveryTimeComboBox.SelectedIndex;

            if (StatusComboBox.SelectedIndex != -1 & _currentCustomer != null)
            {
                foreach (Customer customer in Customers)
                {
                    if (customer.Orders != null)
                    {
                        foreach (PriorityOrder order in customer.Orders)
                        {
                            if (order != null &&
                                order.Id == int.Parse((String)OrdersDataGridView.Rows[OrdersDataGridView.CurrentCell.RowIndex].Cells[0].Value))
                            {
                                order.DesiredDeliveryTime = (DesiredDeliveryTime)DeliveryTimeComboBox.SelectedIndex;

                            }
                        }
                    }
                }
            }
        }
    }
}
