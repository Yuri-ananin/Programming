using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Enums;
using System.Windows.Forms;
using System.Reflection;
using Rectangle = Programming.Model.Rectangle;
using Programming.Model;

namespace Programming
{
    public partial class MainForm : Form
    {
        private Rectangle[] _rectangles = new Rectangle[5];
        private Rectangle _currentRectangle = new Rectangle();
        private Film[] _films = new Film[5];
        private Film _currentFilm = new Film();

        public MainForm()
        {
            InitializeComponent();

            Random random = new Random();

            string[] colors = { "White", "Yellow", "Blue", "Green", "Purple" };
            string[] names_films = { "Once Upon a Time in Hollywood", "Brigth Star", "The Dark Knight", "Fahrenheit 9/11", "Private Life" };
            string[] genre = { "Action", "Comedy", "Drama", "Fantasy", "Horror", "Mystery" };
            string[] enums = { "Colors", "EducationForm", "Genre", "Manufactures", "Season", "Weekday" };
            EnumsListBox.DataSource = enums;
            EnumsListBox.SelectedIndex = 0;
            SeasonHandleComboBox.DataSource = Enum.GetValues(typeof(Season));
            SeasonHandleComboBox.SelectedIndex = 0;

            for(int i = 0; i < 5; i++)
            {
                var Length = random.Next(1, 25);
                var Width = random.Next(1, 25);
                int randIndex = random.Next(colors.Length);
                var CurrentColors = colors[randIndex];
                _rectangles[i] = new Rectangle(Length, Width, CurrentColors);
            }

            for(int i = 0; i < 5; i++)
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

        private int FindRectangleWithMaxWidth()
        {
            double maxWidthRectangle = 0;
            int IndexRectangleWithMaxWidth = 0;
            for (int i = 0; i < RectanglesListBox.Items.Count; i++)
            {
                var currentWidthRectangle = _rectangles[i].Width;
                if (currentWidthRectangle > maxWidthRectangle)
                {
                    maxWidthRectangle = currentWidthRectangle;
                    IndexRectangleWithMaxWidth = i;
                }
            }
            return IndexRectangleWithMaxWidth;
        }

        private int FindFilmWithMaxRating()
        {
            double maxRatingFilm = 0;
            int IndexFilmWithMaxRating = 0;
            for(int i = 0; i < FilmsListBox.Items.Count; i++)
            {
                var currentRatingFilm = _films[i].Rating;
                if(currentRatingFilm > maxRatingFilm)
                {
                    maxRatingFilm = currentRatingFilm;
                    IndexFilmWithMaxRating = i;
                }
            }
            return IndexFilmWithMaxRating;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            string enumerations = EnumsListBox.Text;
            Type type = Type.GetType(String.Format("Programming.Model.Enums.{0}", enumerations));
            var values = Enum.GetValues(type).Cast<object>().ToArray();
            ValuesListBox.Items.AddRange(values);
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var value = (int)ValuesListBox.SelectedItem;
            ValuesTextBox.Text = value.ToString();
        }

        private void WeekdayParsingButton_Click(object sender, EventArgs e)
        {
            Weekday text;
            if (Enum.TryParse(WeekdayParsingTextBox.Text, out text))
            {
                WeekdayParsingLabel.Text = String.Format("Это день недели ({0} = {1})", text, (int)text);
            }
            else
            {
                WeekdayParsingLabel.Text = "Нет такого дня недели";
            }
        }

        private void SeasonHandleButton_Click(object sender, EventArgs e)
        {
            SeasonHandleGroupBox.BackColor = Color.White;
            SeasonHandleLabel.Text = " ";
            switch (Enum.Parse(typeof(Season), SeasonHandleComboBox.Text).ToString())
            {
                case "Winter":
                    {
                        SeasonHandleLabel.Text = "Бррр! Холодно!";
                        break;
                    }
                case "Summer":
                    {
                        SeasonHandleLabel.Text = "Ура! Солнце!";
                        break;
                    }
                case "Autumn":
                    {
                        SeasonHandleGroupBox.BackColor = ColorTranslator.FromHtml("#e29c45");
                        break;
                    }
                case "Spring":
                    {
                        SeasonHandleGroupBox.BackColor = ColorTranslator.FromHtml("#559c45");
                        break;
                    }
            }
        }
<<<<<<< HEAD
=======

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[indexRectangle];
            LengthTextBox.Text = _currentRectangle.Length.ToString();
            WidthTextBox.Text = _currentRectangle.Width.ToString();
            ColorTextBox.Text = _currentRectangle.Color.ToString();
        }

        private void LengthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (LengthTextBox.Text == "")
                {
                    LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                var lengthRectangle = Convert.ToDouble(LengthTextBox.Text);
                _currentRectangle.Length = lengthRectangle;
                LengthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (FormatException)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Введите число.");
            }
            catch (OverflowException)
            {
                LengthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Некорректное значение.");
            }
        }

        private void WidthTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (WidthTextBox.Text == "")
                {
                    WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                var widthRectangle = Convert.ToDouble(WidthTextBox.Text);
                _currentRectangle.Width = widthRectangle;
                WidthTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (FormatException)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Введите число.");
            }
            catch (OverflowException)
            {
                WidthTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show("Некорректное значение.");
            }
        }

        private void ColorTextBox_TextChanged(object sender, EventArgs e)
        {
            _currentRectangle.Color = ColorTextBox.Text;
        }

        private void FindRectangleWithMaxWidthButton_Click(object sender, EventArgs e)
        {
            RectanglesListBox.SelectedIndex = FindRectangleWithMaxWidth();
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
                var ratingFilm = int.Parse(RatingTextBox.Text);
                if (ratingFilm == 0)
                {
                    RatingTextBox.BackColor = System.Drawing.Color.LightPink;
                    return;
                }
                _currentFilm.Rating = ratingFilm;
                RatingTextBox.BackColor = System.Drawing.Color.White;
            }
            catch (ArgumentException ex)
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка ввода");
            }
            catch (FormatException)
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
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
            catch (ArgumentException ex)
            {
                YearTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка ввода");
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
            catch (ArgumentException ex)
            {
                RatingTextBox.BackColor = System.Drawing.Color.LightPink;
                MessageBox.Show(ex.Message, "Ошибка ввода");
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
>>>>>>> 412d38c6c02038aff09eb90fb23b2de080351c8b
    }
}