using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.Services;
using Newtonsoft.Json.Bson;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле хранящее данные типа <see cref="Store"/>.
        /// </summary>
        private readonly Store _store = new Store();

        /// <summary>
        /// Возвращает данные типа <see cref="Store"/>
        /// </summary>
        internal Store Store
        {
            get
            {
                return _store;
            }
        }
        public MainForm()
        {
            InitializeComponent();
            StoreSerializer.StoreInfo(ref _store);
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            OrdersTab.Customers = _store.Customers;;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _store.Items = ItemsTab.Items;
            _store.Customers = CustomersTab.Customers;
            StoreSerializer.SaveStore(_store);
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            _store.Items = ItemsTab.Items;
            _store.Customers = CustomersTab.Customers;

            if (TabControl.SelectedIndex == 2)
            {
                CartsTab.Customers = _store.Customers;
                CartsTab.Items = _store.Items;
            }
            if (TabControl.SelectedIndex == 3)
            {
                OrdersTab.Customers = _store.Customers;
            }
        }
    }
}