using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Class;

namespace Programming.Model
{
    /// <summary>
    /// Класс, опысывающий фильм.
    /// </summary>
    internal class Film
    {
        /// <summary>
        /// Продолжительность фильма в минутах.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Год выхода фильма.
        /// </summary>
        private int _year;
     
        /// <summary>
        /// Рейтинг фильма.
        /// </summary>
        private double _rating;

        /// <summary>
        /// Возвращает и задает жанр фильма.
        /// </summary>
        public string Genre { get; set; }

        /// <summary>
        /// Возвращает и задает название фильма.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность фильма. Должна быть положительным числом.
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _duration = value;
            }
        }

        /// <summary>
        /// Возвращает и задает год выхода фильма. Должен быть числом от 1900 до 2023.
        /// </summary>
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                Validator.AssertValueInRange(value, 1900, 2023);
                _year = value;
            }
        }

        /// <summary>
        /// Возвращает и задает рейтинг фильма. Должен быть числом от 1 до 10.
        /// </summary>
        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                Validator.AssertValueInRange(value, 1, 10);
                _rating = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Film"/>.
        /// </summary>
        public Film()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Film"/>.
        /// </summary>
        /// <param name="name">Название фильма.</param>
        /// <param name="duration">Длительность фильма. Должна быть положительным числом.</param>
        /// <param name="year">Год выпуска фильма. Должен быть в диапазоне от 1900 до 2023.</param>
        /// <param name="genre">Жанр фильма.</param>
        /// <param name="rating">Рейтинг фильма. Должен быть в диапазоне от 1 до 10.</param>
        public Film(string name, int duration, int year, string genre, double rating)
        {
            this.Name = name;
            this.Duration = duration;
            this.Year = year;
            this.Genre = genre;
            this.Rating = rating;
        }
    }
}
