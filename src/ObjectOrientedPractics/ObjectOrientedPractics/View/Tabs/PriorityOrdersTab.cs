using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Model.Orders;
using ObjectOrientedPractics.View.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ObjectOrientedPractics.View.Tabs
{
    public partial class PriorityOrdersTab : UserControl
    {

        /// <summary>
        /// Текущий приоритетный заказ <see cref="PriorityOrder"/>.
        /// </summary>
        private PriorityOrder _priorityOrder = new();

        /// <summary>
        /// Возвращает и задает приоритетный заказ.
        /// </summary>
        internal PriorityOrder PriorityOrder
        {
            get => _priorityOrder;
            set => _priorityOrder = value;
        }

        /// <summary>
        /// Счётчик id.
        /// </summary>
        private int _counter = 0;

        /// <summary>
        /// экземпляр класса <see cref="Random"/>.
        /// </summary>
        private Random random = new Random();

        public PriorityOrdersTab()
        {
            InitializeComponent();

            StatusComboBox.DataSource = Enum.GetValues(typeof(OrderStatus));

            PriorityOrder.Items = new List<Item>();

            AddressControl.Address = new Address(random.Next(100000, 999999), "Рандомная страна", "Рандомный город", "Рандомная улица", "Cтроение", "Квартира");

            DateTime date = DateTime.Now;
            IDTextBox.Text = _counter.ToString();
            CreatedTextBox.Text = date.ToString();
            PriorityOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedValue;

            for (int i = 0; i < Enum.GetNames(typeof(DesiredDeliveryTime)).Length; i++)
            {
                var enumType = typeof(DesiredDeliveryTime);
                var memberInfos =
                enumType.GetMember(Enum.Parse(typeof(DesiredDeliveryTime), i.ToString()).ToString());
                var enumValueMemberInfo = memberInfos.FirstOrDefault(m => m.DeclaringType == enumType);
                var valueAttributes = enumValueMemberInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                var description = ((DescriptionAttribute)valueAttributes[0]).Description;
                DeliveryComboBox.Items.Add(description);
            }
        }

        private void StatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriorityOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedValue;
        }

        private void DeliveryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PriorityOrder.DesiredDeliveryTime =
                (DesiredDeliveryTime)DeliveryComboBox.SelectedIndex;
        }

        private void OrderItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OrderItemsListBox.Items.Count == 0)
            {
                ClearButton.Enabled = false;
                AddressControl.Enabled = false;
                AddressControl.AddressClear();
            }

            if (OrderItemsListBox.SelectedIndex == -1)
            {
                RemoveButton.Enabled = false;
                return;
            }

            AddressControl.Address = PriorityOrder.Address;
            StatusComboBox.SelectedItem = PriorityOrder.OrderStatus;
            RemoveButton.Enabled = true;
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            Item randomItem = Item.GenerateRandomItem();
            OrderItemsListBox.Items.Add(randomItem);
            PriorityOrder.Items.Add(randomItem);
            PriceLabel.Text = PriorityOrder.Amount.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.Items.Count > 0)
            {
                _counter++;
                OrderItemsListBox.Items.Clear();
                PriceLabel.Text = "0";
                CreatedTextBox.Text = DateTime.Now.ToString();
                IDTextBox.Text = _counter.ToString();
                StatusComboBox.SelectedIndex = 0;
                DeliveryComboBox.SelectedIndex = -1;

                PriorityOrder = new PriorityOrder();
                PriorityOrder.Items = new List<Item>();
                PriorityOrder.OrderStatus = (OrderStatus)StatusComboBox.SelectedValue;
                AddressControl.Address = new Address(random.Next(100000, 999999),
                    "Другая рандомная страна", "Другой рандомный город", "Другая рандомная улица", "Cтроение", "Квартира");
                StatusComboBox.SelectedIndex = 0;
                DeliveryComboBox.SelectedIndex = 0;
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (OrderItemsListBox.Items.Count > 0 && OrderItemsListBox.SelectedIndex != -1)
            {
                int selectedIndex = OrderItemsListBox.SelectedIndex;
                PriorityOrder.Items.RemoveAt(selectedIndex);
                OrderItemsListBox.Items.RemoveAt(selectedIndex);

                PriceLabel.Text = PriorityOrder.Amount.ToString();

                if (selectedIndex == OrderItemsListBox.Items.Count)
                {
                    OrderItemsListBox.SelectedIndex = selectedIndex - 1;
                    return;
                }
                OrderItemsListBox.SelectedIndex = selectedIndex;
            }
        }
    }
}
