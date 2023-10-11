using ObjectOrientedPractics.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;
using System.Text.Json.Serialization;
using static System.Environment;
using System.Net.Http.Json;
using Newtonsoft.Json;

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
        /// Индекс текущего выбранного элемента перед сортировкой.
        /// </summary>
        private int _indexBeforeSort;

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
        /// Название файла для записи данных.
        /// </summary>
        private string _fileName = "Items.Json";

        public ItemsTab()
        {
            InitializeComponent();
            LoadItemsInfo();
            ToggleInputBoxes(false);
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
                _currentItem = new Model.Item(
                    NameTextBox.Text,
                    DescriptionTextBox.Text,
                    Convert.ToDouble(CostTextBox.Text)
                );
                _itemsList.Add(_currentItem);
                Sort();
                SaveItem();
                ToggleInputBoxes(false);
                return;
            }
            else
            {
                _itemsList[_selectedIndex] = _cloneCurrentItem;
                _currentItem = _cloneCurrentItem;
            }

            Sort();
            SaveItem();
            ToggleInputBoxes(false);
            UpdateItemInfo();
            ItemsListBox.ClearSelected();
            ClearItemInfo();
        }

        private void ItemsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ItemsListBox.SelectedIndex != -1)
            {
                ToggleInputBoxes(false);
                _cloneCurrentItem = (Item)_itemsList[ItemsListBox.SelectedIndex].Clone();
                NameTextBox.Text = _cloneCurrentItem.Name.ToString();
                DescriptionTextBox.Text = _cloneCurrentItem.Info.ToString();
                CostTextBox.Text = _cloneCurrentItem.Cost.ToString();
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
            SaveItem();
            Sort();
            ClearItemInfo();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ItemsListBox.Items.Count == 0 || ItemsListBox.SelectedIndex == -1)
            {
                return;
            }

            _selectedIndex = ItemsListBox.SelectedIndex;
            _cloneCurrentItem = (Model.Item)_itemsList[_selectedIndex].Clone();
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

        /// <summary>
        /// Метод, который сохраняет данные в json файл.
        /// </summary>
        public void SaveItem()
        {
            if (ItemsListBox.Items.Count != 0)
            {
                var jsonString = System.Text.Json.JsonSerializer.Serialize(_itemsList);
                File.WriteAllText("Items.json", jsonString);
            }
        }

        private void LoadItemsInfo()
        {
            if (File.Exists(_fileName))
            {
                _itemsList = JsonConvert.DeserializeObject<List<Item>>(File.ReadAllText(_fileName));
                Sort();
            }
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
        }

        /// <summary>
        /// Метод, который обновляет данные текущего выбранного товара в TextBox.
        /// </summary>
        private void UpdateItemInfo()
        {
            NameTextBox.Text = _currentItem.Name.ToString();
            DescriptionTextBox.Text = _currentItem.Info.ToString();
            CostTextBox.Text = _currentItem.Cost.ToString();
        }

        /// <summary>
        /// Метод который сортирует <see cref="_itemsList"/> и <see cref="ItemsListBox"/>
        /// и загружает данные из <see cref="_itemsList"/> в <see cref="ItemsListBox"/>.
        /// </summary>
        private void Sort()
        {
            _indexBeforeSort = ItemsListBox.SelectedIndex;
            ItemsListBox.SelectedIndexChanged -= ItemsListBox_SelectedIndexChanged;
            _itemsList = _itemsList.OrderBy(song => song.ToString()).ToList();
            ItemsListBox.DataSource = _itemsList;
            ItemsListBox.SelectedIndex = _indexBeforeSort;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
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
    }
}
