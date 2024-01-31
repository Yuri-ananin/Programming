using System.Data;
using SongsListApp.Model.Classes;
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
        /// Правильность ввода названия песни.
        /// </summary>
        private bool _isValidDataName = true;

        /// <summary>
        /// Правильность ввода имени артиста.
        /// </summary>
        private bool _isValidDataArtist = true;

        /// <summary>
        /// Правильность ввода длительности песни.
        /// </summary>
        private bool _isValidDataDuration = true;

        /// <summary>
        /// Правильность ввода жанра песни.
        /// </summary>
        private bool _isValidDataGenre = true;

        /// <summary>
        /// Индекс текущего выбранного элемента перед сортировкой
        /// для сохранения выбранного элемента в SongsListBox.
        /// </summary>
        private int _indexBeforeSort;

        /// <summary>
        /// Индекс текущего выбранного элемента для добавления и редактирования элементов.
        /// </summary>
        private int _selectedIndex;

        public SongsControl()
        {
            InitializeComponent();
            _songsList = ProjectManager.LoadSongs();
            Sort();
            ClearSongInfo();
            SongsListBox.SelectedIndex = -1;
            SongGenreComboBox.DataSource = Enum.GetValues(typeof(Genre));
            SongGenreComboBox.SelectedIndex = -1;
            ToggleInputBoxes(false);
        }

        private void GenreComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (SongGenreComboBox.SelectedIndex != -1 && _cloneCurrentSong.Genre != null)
            {
                Enum.Parse(typeof(Genre), _cloneCurrentSong.Genre);
                _cloneCurrentSong.Genre = SongGenreComboBox.SelectedItem.ToString();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ClearSongInfo();
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
            ProjectManager.SaveSongs(_songsList);
            Sort();
            ClearSongInfo();
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

        private void SongsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SongsListBox.SelectedIndex != -1)
            {
                ToggleInputBoxes(false);
                _cloneCurrentSong = (Song)_songsList[SongsListBox.SelectedIndex].Clone();
                SongNameTextBox.Text = _cloneCurrentSong.Name.ToString();
                ArtistNameTextBox.Text = _cloneCurrentSong.Artist.ToString();
                SongDurationTextBox.Text = _cloneCurrentSong.Duration.ToString();
                SongGenreComboBox.Text = _cloneCurrentSong.Genre;
            }
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(SongDurationTextBox.Text))
                {
                    if (!int.TryParse(SongDurationTextBox.Text, out var number))
                    {
                        SongDurationTextBox.BackColor = Color.LightPink;
                        SongDurationErrorLabel.Visible = true;
                        _isValidDataDuration = false;
                        CheckData();
                        return;
                    }

                    _cloneCurrentSong.Duration = Convert.ToInt32(SongDurationTextBox.Text);
                    SongDurationTextBox.BackColor = Color.White;
                    SongDurationErrorLabel.Visible = false;
                    _isValidDataDuration = true;
                    CheckData();
                }
            }

            catch (ArgumentException)
            {
                SongDurationTextBox.BackColor = Color.LightPink;
                SongDurationErrorLabel.Visible = true;
                _isValidDataDuration = false;
                CheckData();
            }
        }

        private void SongNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(SongNameTextBox.Text))
                {
                    Validator.AssertStringContainsOnlyEnglishLetters(SongNameTextBox.Text);
                    _cloneCurrentSong.Name = SongNameTextBox.Text;
                    SongNameTextBox.BackColor = Color.White;
                    SongNameErrorLabel.Visible = false;
                    _isValidDataName = true;
                    CheckData();
                    return;
                }

                else
                {
                    SongNameTextBox.BackColor = Color.LightPink;
                    SongNameErrorLabel.Visible = true;
                    _isValidDataName = false;
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                SongNameTextBox.BackColor = Color.LightPink;
                SongNameErrorLabel.Visible = true;
                _isValidDataName = false;
                CheckData();
            }
        }

        private void ArtistNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(ArtistNameTextBox.Text))
                {
                    Validator.AssertStringContainsOnlyEnglishLetters(ArtistNameTextBox.Text);
                    _cloneCurrentSong.Artist = ArtistNameTextBox.Text;
                    ArtistNameTextBox.BackColor = Color.White;
                    ArtistNameErrorLabel.Visible = false;
                    _isValidDataArtist = true;
                    CheckData();
                    return;
                }

                else
                {
                    ArtistNameTextBox.BackColor = Color.LightPink;
                    ArtistNameErrorLabel.Visible = true;
                    _isValidDataArtist = false;
                    CheckData();
                }
            }
            catch (ArgumentException)
            {
                ArtistNameTextBox.BackColor = Color.LightPink;
                ArtistNameErrorLabel.Visible = true;
                _isValidDataArtist = false;
                CheckData();
            }
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SongNameTextBox.Text) ||
                string.IsNullOrEmpty(ArtistNameTextBox.Text) ||
                string.IsNullOrEmpty(SongDurationTextBox.Text) ||
                string.IsNullOrEmpty(SongGenreComboBox.Text))
            {
                MessageBox.Show("Заполните все поля.", "Ошибка ввода");
                return;
            }

            if (_selectedIndex == -1)
            {
                _currentSong = new Song(
                    SongNameTextBox.Text.ToString(),
                    ArtistNameTextBox.Text.ToString(),
                    Convert.ToInt32(SongDurationTextBox.Text),
                    SongGenreComboBox.Text.ToString()
                );
                _songsList.Add(_currentSong);
                Sort();
                ProjectManager.SaveSongs(_songsList);
                ToggleInputBoxes(false);
                return;
            }

            _songsList[_selectedIndex] = _cloneCurrentSong;
            _currentSong = _cloneCurrentSong;
            Sort();
            ProjectManager.SaveSongs(_songsList);
            ToggleInputBoxes(false);
            UpdateSongInfo();
            ClearSongInfo();
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

        /// <summary>
        /// Метод, проверяющий значения текстовых полей и не дающий их сохранить в случае неправильного ввода.
        /// </summary>
        private void CheckData()
        {
            if (_isValidDataName && _isValidDataArtist && _isValidDataDuration && _isValidDataGenre)
            {
                ApplyButton.Enabled = true;
            }
            else
            {
                ApplyButton.Enabled = false;
            }
        }

        /// <summary>
        /// Метод, который очищает текстовые поля и ComboBox.
        /// </summary>
        private void ClearSongInfo()
        {
            SongNameTextBox.Clear();
            ArtistNameTextBox.Clear();
            SongDurationTextBox.Clear();
            SongGenreComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Метод, который включает или отключает все TextBox, ComboBox и ApplyButton.
        /// </summary>
        /// <param name="value">True or false.</param>
        private void ToggleInputBoxes(bool value)
        {
            SongNameTextBox.Enabled = value;
            ArtistNameTextBox.Enabled = value;
            SongDurationTextBox.Enabled = value;
            SongGenreComboBox.Enabled = value;
            ApplyButton.Visible = value;
        }

        /// <summary>
        /// Метод, который обновляет данные текущей выбранной песни в TextBox и ComboBox.
        /// </summary>
        private void UpdateSongInfo()
        {
            SongNameTextBox.Text = _currentSong.Name.ToString();
            ArtistNameTextBox.Text = _currentSong.Artist.ToString();
            SongDurationTextBox.Text = _currentSong.Duration.ToString();
            SongGenreComboBox.Text = _currentSong.Genre.ToString();
        }
    }
}