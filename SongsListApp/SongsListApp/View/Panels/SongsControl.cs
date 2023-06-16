using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using SongsListApp.Model.Classes;
using Newtonsoft.Json;
using SongsListApp.Model.Enums;

namespace SongsListApp
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления,
    /// содержащий элементы для управления списком песен.
    /// </summary>
    public partial class SongsControl : UserControl
    {
        /// <summary>
        /// Список с данными о песнях.
        /// </summary>
        private List<Song> _songsList = new List<Song>();

        /// <summary>
        /// Список с данными текущей выбранной песни.
        /// </summary>
        private Song _currentSong = new Song();

        /// <summary>
        /// Копия текущей выбранной песни.
        /// </summary>
        private Song _cloneCurrentSong = new();

        /// <summary>
        /// Индекс текущего выбранного элемента перед сортировкой
        /// для сохранения выбранного элемента в SongsListBox.
        /// </summary>
        private int _indexBeforeSort;

        /// <summary>
        /// Индекс текущего выбранного элемента для добавления и редактирования элементов.
        /// </summary>
        private int _selectedIndex;

        /// <summary>
        /// Название файла для сохранения или загрузки данных.
        /// </summary>
        private string _fileName = "Songs.Json";

        public SongsControl()
        {
            InitializeComponent();
            LoadSongsInfo();
            ClearSongsInfo();
            SongsListBox.SelectedIndex = -1;

            // заполнение GenreComboBox
            GenreComboBox.DataSource = Enum.GetValues(typeof(Genre));
            GenreComboBox.SelectedIndex = -1;
            ToggleInputBoxes(false);
        }

        /// <summary>
        /// Метод, который сохраняет данные всех песен в json файл (Songs.json).
        /// </summary>
        public void SaveSong()
        {
            if (SongsListBox.Items.Count != 0)
            {
                var jsonString = System.Text.Json.JsonSerializer.Serialize(_songsList);
                File.WriteAllText("Songs.json", jsonString);
            }
        }

        /// <summary>
        /// Метод, который очищает текстовые поля и ComboBox.
        /// </summary>
        private void ClearSongsInfo()
        {
            SongNameTextBox.Clear();
            PerformerNameTextBox.Clear();
            DurationTextBox.Clear();
            GenreComboBox.SelectedIndex = -1;
        }
        
        /// <summary>
        /// Метод, который включает или отключает все TextBox, ComboBox и ApplyButton.
        /// </summary>
        /// <param name="value">True or false.</param>
        private void ToggleInputBoxes(bool value)
        {
            SongNameTextBox.Enabled = value;
            PerformerNameTextBox.Enabled = value;
            DurationTextBox.Enabled = value;
            GenreComboBox.Enabled = value;
            ApplyButton.Visible = value;
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (GenreComboBox.SelectedIndex != -1 && _cloneCurrentSong.Genre != null)
            {
                Enum.Parse(typeof(Genre), _cloneCurrentSong.Genre);
                _cloneCurrentSong.Genre = GenreComboBox.SelectedItem.ToString();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ClearSongsInfo();
            SongsListBox.SelectedIndex = -1;
            _selectedIndex = -1;
            ToggleInputBoxes(true);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (SongsListBox.Items.Count == 0 || SongsListBox.SelectedIndex == -1)
            {
                return;
            }
            _currentSong = _songsList[SongsListBox.SelectedIndex];
            _songsList.Remove(_currentSong);
            SongsListBox.SelectedIndex = -1;
            SaveSong();
            Sort();
            ClearSongsInfo();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (SongsListBox.Items.Count == 0 || SongsListBox.SelectedIndex == -1)
            {
                return;
            }

            _selectedIndex = SongsListBox.SelectedIndex;
            _cloneCurrentSong = (Song)_songsList[_selectedIndex].Clone();
            ToggleInputBoxes(true);
        }

        /// <summary>
        /// Метод, который сортирует <see cref="_songsList"/> и <see cref="SongsListBox"/>
        /// в алфавитном порядке.
        /// </summary>
        private void Sort()
        {
            _indexBeforeSort = SongsListBox.SelectedIndex;
            SongsListBox.SelectedIndexChanged -= SongsListBox_SelectedIndexChanged;
            _songsList = _songsList.OrderBy(song => song.ToString()).ToList();
            SongsListBox.DataSource = _songsList;
            SongsListBox.SelectedIndex = _indexBeforeSort;
            SongsListBox.SelectedIndexChanged += SongsListBox_SelectedIndexChanged;
        }

        private void SongsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SongsListBox.SelectedIndex != -1)
            {
                ToggleInputBoxes(false);
                _cloneCurrentSong = (Song)_songsList[SongsListBox.SelectedIndex].Clone();
                SongNameTextBox.Text = _cloneCurrentSong.Name.ToString();
                PerformerNameTextBox.Text = _cloneCurrentSong.Performer.ToString();
                DurationTextBox.Text = _cloneCurrentSong.Duration.ToString();
                GenreComboBox.Text = _cloneCurrentSong.Genre;
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SongNameTextBox.Text) ||
                string.IsNullOrEmpty(PerformerNameTextBox.Text) ||
                string.IsNullOrEmpty(DurationTextBox.Text) ||
                string.IsNullOrEmpty(GenreComboBox.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка ввода");
                return;
            }

            if (_selectedIndex == -1)
            {
                _currentSong = new Song(
                    SongNameTextBox.Text.ToString(),
                    PerformerNameTextBox.Text.ToString(),
                    Convert.ToInt32(DurationTextBox.Text),
                    GenreComboBox.Text.ToString()
                );
                _songsList.Add(_currentSong);
                Sort();
                SaveSong();
                ToggleInputBoxes(false);
                return;
            }

            _songsList[_selectedIndex] = _cloneCurrentSong;
            _currentSong = _cloneCurrentSong;
            Sort();
            SaveSong();
            ToggleInputBoxes(false);
            UpdateSongInfo();
        }

        /// <summary>
        /// Метод, который обновляет данные текущей выбранной песни в TextBox и ComboBox.
        /// </summary>
        private void UpdateSongInfo()
        {
            SongNameTextBox.Text = _currentSong.Name.ToString();
            PerformerNameTextBox.Text = _currentSong.Performer.ToString();
            DurationTextBox.Text = _currentSong.Duration.ToString();
            GenreComboBox.Text = _currentSong.Genre.ToString();
        }

        /// <summary>
        /// Метод, который построчно считывает текстовый файл 
        /// для заполнения <see cref="SongsListBox"/> и <see cref="_songsList"/>.
        /// </summary>
        private void LoadSongsInfo()
        {
            if (File.Exists(_fileName))
            {
                _songsList = JsonConvert.DeserializeObject<List<Song>>(File.ReadAllText(_fileName));
                Sort();
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(DurationTextBox.Text))
                {
                    if (!int.TryParse(DurationTextBox.Text, out var number))
                    {
                        DurationTextBox.BackColor = Color.LightPink;
                        return;
                    }

                    _cloneCurrentSong.Duration = Convert.ToInt32(DurationTextBox.Text);
                    DurationTextBox.BackColor = Color.White;
                }
            }
            catch (FormatException)
            {
                DurationTextBox.BackColor = Color.LightPink;
            }
            catch (OverflowException)
            {
                DurationTextBox.BackColor = Color.LightPink;
            }
        }

        private void SongNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(SongNameTextBox.Text))
                {
                    if (Validator.CheckStringContainsOnlyEnglishLetters(SongNameTextBox.Text))
                    {
                        _cloneCurrentSong.Name = SongNameTextBox.Text;
                        SongNameTextBox.BackColor = Color.White;
                        return;
                    }

                    else
                    {
                        SongNameTextBox.BackColor = Color.LightPink;
                    }
                }
            }

            catch (ArgumentException ex)
            {
                SongNameTextBox.BackColor = Color.LightPink;
            }
        }

        private void PerformerNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(PerformerNameTextBox.Text))
                {
                    if (Validator.CheckStringContainsOnlyEnglishLetters(PerformerNameTextBox.Text))
                    {
                        _cloneCurrentSong.Performer = PerformerNameTextBox.Text;
                        PerformerNameTextBox.BackColor = Color.White;
                    }
                    else
                    {
                        PerformerNameTextBox.BackColor = Color.LightPink;
                    }
                }
            }
            catch (ArgumentException ex)
            {
                PerformerNameTextBox.BackColor = Color.LightPink;
            }
        }
    }
}