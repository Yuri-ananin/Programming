using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model;

namespace Programming.View.Controls
{
    /// <summary>
    /// Класс, описывающий пользовательский элемент управления, содержащий FilmsGroupBox.
    /// </summary>
    public partial class FilmsControl : UserControl
    {
        /// <summary>
        /// Инициализация массива с фильмами размерерностью 5.
        /// </summary>
        private Film[] _films = new Film[5];

        /// <summary>
        /// Массив с данными текущего выбранного фильма.
        /// </summary>
        private Film _currentFilm = new Film();

        public FilmsControl()
        {
            InitializeComponent();
            Random random = new Random();
            string[] names_films = { "Once Upon a Time in Hollywood", "Brigth Star", "The Dark Knight", "Fahrenheit 9/11", "Private Life" };
            string[] genre = { "Action", "Comedy", "Drama", "Fantasy", "Horror", "Mystery" };
            for (int i = 0; i < 5; i++)
            {
                var Duration = random.Next(60, 180);
                var Rating = random.Next(1, 11);
                var Year = random.Next(1980, 2024);
                int randIndex_genres = random.Next(genre.Length);
                var CurrentName = names_films[i];
                var CurrentGenre = genre[randIndex_genres];
                _films[i] = new Film(CurrentName, Duration, Year, CurrentGenre, Rating);
                FilmsListBox.Items.Add(CurrentName);
            }
        }

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexFilm = FilmsListBox.SelectedIndex;
            _currentFilm = _films[indexFilm];
            RatingTextBox.Text = _currentFilm.Rating.ToString();
            YearTextBox.Text = _currentFilm.Year.ToString();
            GenreTextBox.Text = _currentFilm.Genre.ToString();
            DurationTextBox.Text = _currentFilm.Duration.ToString();
        }

        private void DurationTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var durationFilm = int.Parse(DurationTextBox.Text);
                if (durationFilm == 0)
                {
                    RatingTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                _currentFilm.Duration = durationFilm;
                DurationTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException)
            {
                DurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (FormatException)
            {
                DurationTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void YearTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var yearFilm = int.Parse(YearTextBox.Text);
                _currentFilm.Year = yearFilm;
                YearTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException)
            {
                YearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (FormatException)
            {
                YearTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void GenreTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentFilm.Genre = GenreTextBox.Text;
        }

        private void RatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var ratingFilm = int.Parse(RatingTextBox.Text);
                if (ratingFilm == 0)
                {
                    RatingTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                _currentFilm.Rating = ratingFilm;
                RatingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException)
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
            catch (FormatException)
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void FindFilmWithMaxRatingButton_Click(object sender, EventArgs e)
        {
            FilmsListBox.SelectedIndex = FindFilmWithMaxRating();
        }

        /// <summary>
        /// Поиск фильма с максимальным рейтингом в списке фильмов.
        /// </summary>
        /// <returns>Индекс фильма с максимальным рейтингом.</returns>
        private int FindFilmWithMaxRating()
        {
            double maxRatingFilm = 0;
            int IndexFilmWithMaxRating = 0;
            for (int i = 0; i < FilmsListBox.Items.Count; i++)
            {
                var currentRatingFilm = _films[i].Rating;
                if (currentRatingFilm > maxRatingFilm)
                {
                    maxRatingFilm = currentRatingFilm;
                    IndexFilmWithMaxRating = i;
                }
            }
            return IndexFilmWithMaxRating;
        }

    }
}
