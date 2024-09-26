using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.Services;
using Newtonsoft.Json.Bson;
using System.Windows.Forms;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле хранящее данные типа <see cref="Store"/>.
        /// </summary>
        private Store _store = new Store();

        public MainForm()
        {
            InitializeComponent();
            CreateData();
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            OrdersTab.Customers = _store.Customers;
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

            CartsTab.Items = _store.Items;
            CartsTab.Customers = _store.Customers;
            OrdersTab.Customers = _store.Customers;
        }

        private void CreateData()
        {
            Random random = new Random();
            for (int i = 1; i < 13; i++)
            {
                _store.Items.Add(new Item($"Item #{i}", $"Info About Item #{i}", random.Next(0, 15000), (Category)Enum.Parse(typeof(Category), $"{random.Next(0, 6)}", true)));
            }
            for (int j = 1; j < 13; j++)
            {
                _store.Customers.Add(new Customer($"Customer #{j}", new Address(150000 + j, "Russia", "Tomsk", "Vershinina", $"{j + 1}", $"{j + 2}")));
            }
        }
    }
}