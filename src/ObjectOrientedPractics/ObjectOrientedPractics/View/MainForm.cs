using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.View.Tabs;
using ObjectOrientedPractics.Services;


namespace ObjectOrientedPractics
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Поле хранящее данные типа <see cref="Store"/>.
        /// </summary>
        private Store _store = new Store();

        internal Store Store => _store;
        public MainForm()
        {
            InitializeComponent();
            StoreSerializer.StoreInfo(ref _store);
            ItemsTab.Items = _store.Items;
            CustomersTab.Customers = _store.Customers;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _store.Items = ItemsTab.Items;
            _store.Customers = CustomersTab.Customers;
            StoreSerializer.SaveStore(_store);
        }
    }
}