using ObjectOrientedPractics.Model;
using System.Data;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.View.Tabs
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, 
    /// содержащий элементы для управления товарами.
    /// </summary>
    public partial class ItemsTab : UserControl
    {

        /// <summary>
        /// Список с данными о товарах.
        /// </summary>
        private List<Item> _itemsList = new List<Item>();

        /// <summary>
        /// Данные о текущем выбранном товаре.
        /// </summary>
        private Item _currentItem = new Item();

        /// <summary>
        /// Индекс текущего выбранного товара.
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Копия текущего выбранного товара.
        /// </summary>
        private Item _cloneCurrentItem = new();

        /// <summary>
        /// Правильность ввода цены на товар.
        /// </summary>
        private bool _isValidDataCost = true;

        /// <summary>
        /// Правильность ввода наименования товара.
        /// </summary>
        private bool _isValidDataName = true;

        /// <summary>
        /// Правильность ввода описания товара.
        /// </summary>
        private bool _isValidDataDescription = true;

        /// <summary>
        /// Список товаров при поиске.
        /// </summary>
        private List<Item> _displayedItems = new List<Item>();

        object[] _categoryValues = Enum.GetValues(typeof(Category)).Cast<object>().ToArray();

        /// <summary>
        /// Возвращает и задаёт список товаров.
        /// </summary>
        internal List<Item> Items
        {
            get
            {
                return _itemsList;
            }
            set
            {
                _itemsList = value;
                SortBy();
            }
        }

        public ItemsTab()
        {
            InitializeComponent();
            ClearItemInfo();
            ItemsListBox.SelectedIndex = -1;
            CategoryComboBox.Items.AddRange(_categoryValues);
            CategoryComboBox.SelectedItem = _categoryValues[0];
            OrderByComboBox.Items.AddRange(new string[] { "Name", "Cost (Ascending)", "Cost (Descending)" });
            OrderByComboBox.SelectedIndex = 0;
            SortBy();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            ClearItemInfo();
            ItemsListBox.SelectedIndex = -1;
            _selectedIndex = -1;
            ToggleInputBoxes(true);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(NameTextBox.Text) ||
                string.IsNullOrEmpty(CostTextBox.Text) ||
                string.IsNullOrEmpty(DescriptionTextBox.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка ввода");
                return;
            }

            if (_selectedIndex == -1)
            {
                _currentItem = new Item(
                    NameTextBox.Text,
                    DescriptionTextBox.Text,
                    Convert.ToDouble(CostTextBox.Text),
                    (Category)CategoryComboBox.SelectedItem);
                _itemsList.Add(_currentItem);
                SortBy();
                ClearItemInfo();
                return;
            }
            else
            {
                _itemsList[_itemsList.IndexOf((Item)ItemsListBox.SelectedItem)] = _cloneCurrentItem;
                _currentItem = _cloneCurrentItem;
            }
            _displayedItems = new List<Item>();
            FindTextBox.Text = string.Empty;
            DataTools.FilterNamePrincipleOfVerification = string.Empty;
            SortBy();
            ToggleInputBoxes(false);
            UpdateItemInfo();
            ItemsListBox.ClearSelected();
            ClearItemInfo();
            ItemsListBox.SelectedIndex = -1;
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                if (_displayedItems.Count != 0)
                {
                    ToggleInputBoxes(false);
                    _cloneCurrentItem = (Item)_displayedItems[ItemsListBox.SelectedIndex].Clone();
                    NameTextBox.Text = _cloneCurrentItem.Name;
                    CostTextBox.Text = _cloneCurrentItem.Cost.ToString();
                    DescriptionTextBox.Text = _cloneCurrentItem.Info;
                    IdTextBox.Text = _cloneCurrentItem.Id.ToString();
                    CategoryComboBox.SelectedItem = _cloneCurrentItem.Category;
                }

                else
                {
                    ToggleInputBoxes(false);
                    _cloneCurrentItem = (Item)ItemsListBox.SelectedItem;
                    _cloneCurrentItem = (Item)_cloneCurrentItem.Clone();
                    NameTextBox.Text = _cloneCurrentItem.Name;
                    DescriptionTextBox.Text = _cloneCurrentItem.Info;
                    CostTextBox.Text = _cloneCurrentItem.Cost.ToString();
                    IdTextBox.Text = _cloneCurrentItem.Id.ToString();
                    CategoryComboBox.SelectedItem = _cloneCurrentItem.Category;
                    EditButton.Enabled = true;
                }
            }
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0 || ItemsListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentItem = _itemsList[ItemsListBox.SelectedIndex];
            _itemsList.Remove(_currentItem);
            ItemsListBox.SelectedIndex = -1;
            SortBy();
            ClearItemInfo();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0 || ItemsListBox.SelectedIndex == -1)
            {
                return;
            }

            _selectedIndex = ItemsListBox.SelectedIndex;
            _cloneCurrentItem = (Item)ItemsListBox.SelectedItem;
            _cloneCurrentItem = (Item)_cloneCurrentItem.Clone();
            ToggleInputBoxes(true);
            SaveButton.Visible = true;
        }

        private void CostTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(CostTextBox.Text))
                {
                    if (!int.TryParse(CostTextBox.Text, out var number))
                    {
                        CostTextBox.BackColor = Color.LightPink;
                        _isValidDataCost = false;
                        CheckData();
                        return;
                    }

                    _cloneCurrentItem.Cost = Convert.ToDouble(CostTextBox.Text);
                    CostTextBox.BackColor = Color.White;
                    _isValidDataCost = true;
                    CheckData();
                }
            }

            catch (ArgumentException)
            {
                CostTextBox.BackColor = Color.LightPink;
                _isValidDataCost = false;
                CheckData();
            }
        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(NameTextBox.Text))
                {
                    _cloneCurrentItem.Name = NameTextBox.Text;
                    NameTextBox.BackColor = Color.White;
                    _isValidDataName = true;
                    CheckData();
                    return;
                }

                else
                {
                    NameTextBox.BackColor = Color.LightPink;
                    _isValidDataName = false;
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                NameTextBox.BackColor = Color.LightPink;
                _isValidDataName = false;
                CheckData();
            }
        }

        private void DescriptionTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(DescriptionTextBox.Text))
                {
                    _cloneCurrentItem.Info = DescriptionTextBox.Text;
                    DescriptionTextBox.BackColor = Color.White;
                    _isValidDataName = true;
                    CheckData();
                    return;
                }

                else
                {
                    DescriptionTextBox.BackColor = Color.LightPink;
                    _isValidDataName = false;
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                DescriptionTextBox.BackColor = Color.LightPink;
                _isValidDataName = false;
                CheckData();
            }
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _cloneCurrentItem.Category = (Category)CategoryComboBox.SelectedItem;
        }

        private void FindTextBox_TextChanged(object sender, EventArgs e)
        {
            DataTools.FilterNamePrincipleOfVerification = FindTextBox.Text;

            ClearItemInfo();

            if (!string.IsNullOrEmpty(FindTextBox.Text))
            {
                _displayedItems = DataTools.ItemsFiltred(_itemsList, DataTools.ItemFilterByName);
                ItemsListBox.DataSource = _displayedItems;
            }

            else
            {
                ItemsListBox.DataSource = _itemsList;
                SortBy();
                _displayedItems = new List<Item>();
                FindTextBox.Text = string.Empty;
            }
        }

        private void OrderByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortBy();
        }

        /// <summary>
        /// Метод, который отключает или включает TextBox.
        /// </summary>
        /// <param name="value"></param>
        private void ToggleInputBoxes(bool value)
        {
            CostTextBox.Enabled = value;
            NameTextBox.Enabled = value;
            DescriptionTextBox.Enabled = value;
            SaveButton.Visible = value;
            CategoryComboBox.Enabled = value;
        }

        /// <summary>
        /// Метод, который обновляет данные текущего выбранного товара в TextBox.
        /// </summary>
        private void UpdateItemInfo()
        {
            NameTextBox.Text = _currentItem.Name.ToString();
            DescriptionTextBox.Text = _currentItem.Info.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
            CategoryComboBox.Text = _currentItem.Category.ToString();
        }

        /// <summary>
        /// Метод, который очищает все TextBox.
        /// </summary>
        private void ClearItemInfo()
        {
            NameTextBox.Text = string.Empty;
            NameTextBox.BackColor = Color.White;
            DescriptionTextBox.Text = string.Empty;
            DescriptionTextBox.BackColor = Color.White;
            IdTextBox.Text = string.Empty;
            CostTextBox.Text = string.Empty;
            CostTextBox.BackColor = Color.White;
            CategoryComboBox.Text = string.Empty;
        }

        /// <summary>
        /// Метод, который проверяет правильность ввода данных, 
        /// и не даёт сохранить их в случае ввода неправильных данных.
        /// </summary>
        private void CheckData()
        {
            if (_isValidDataName && _isValidDataDescription && _isValidDataCost)
            {
                SaveButton.Enabled = true;
            }
            else
            {
                SaveButton.Enabled = false;
            }
        }

        /// <summary>
        /// Метод для сортировки товаров в зависимости от выбранного значения.
        /// </summary>
        private void SortBy()
        {
            var testSelectedItem = ItemsListBox.SelectedItem;
            ItemsListBox.DataSource = null;
            if (OrderByComboBox.SelectedIndex == 0)
            {
                CompareValues compare = DataTools.CompareName;
                _itemsList = DataTools.Sort(_itemsList, compare);
                _displayedItems = DataTools.Sort(_displayedItems, compare);
            }

            else if (OrderByComboBox.SelectedIndex == 1)
            {
                CompareValues compare = DataTools.CompareAscending;
                _itemsList = DataTools.Sort(_itemsList, compare);
                _displayedItems = DataTools.Sort(_displayedItems, compare);
            }

            else if (OrderByComboBox.SelectedIndex == 2)
            {
                CompareValues compare = DataTools.CompareDescending;
                _itemsList = DataTools.Sort(_itemsList, compare);
                _displayedItems = DataTools.Sort(_displayedItems, compare);
            }

            if (!string.IsNullOrEmpty(FindTextBox.Text))
            {
                _displayedItems = DataTools.ItemsFiltred(_displayedItems, DataTools.ItemFilterByName);
                ItemsListBox.SelectedIndexChanged -= ItemsListBox_SelectedIndexChanged;
                ItemsListBox.DataSource = _displayedItems;
                ItemsListBox.SelectedIndex = -1;
                ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            }

            else
            {
                FindTextBox.Text = string.Empty;
                ItemsListBox.DataSource = _itemsList;
            }
        }
    }
}
