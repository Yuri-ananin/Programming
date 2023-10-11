using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsListApp.Model.Classes
{
    /// <summary>
    /// Класс, описывающий песню.
    /// </summary>
    internal class Song: ICloneable
    {
        /// <summary>
        /// Название песни.
        /// </summary>
        private string _name;

        /// <summary>
        /// Название исполнителя.
        /// </summary>
        private string _performer;

        /// <summary>
        /// Длительность песни в секундах.
        /// </summary>
        private int _duration;

        /// <summary>
        /// Возвращает и задает жанр песни.
        /// </summary>
        public string Genre { get;set; }

        /// <summary>
        /// Возвращает и задает название песни. Должно быть написано на латинице и иметь длину в диапазоне от 0 до 50 символов.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (!Validator.CheckStringContainsOnlyEnglishLetters(value))
                {
                    throw new ArgumentException($"Допустима только латиница в названии песни.");
                }

                Validator.AssertValueInRange(value.Length, 0, 50);
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает название исполнителя песни. Должно быть написано на латинице и иметь длину в диапазоне от 0 до 50 символов.
        /// </summary>
        public string Performer
        {
            get
            {
                return _performer;
            }
            set
            {
                if (!Validator.CheckStringContainsOnlyEnglishLetters(value))
                {
                    throw new ArgumentException($"Допустима только латиница в названии исполнителя.");
                }

                Validator.AssertValueInRange(value.Length, 0, 50);
                _performer = value;
            }
        }
        
        /// <summary>
        /// Возвращает и задает длительность песни в секундах. Должна быть в диапазоне от 0 до 7200.
        /// </summary>
        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 7200);
                _duration = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Song"/>.
        /// </summary>
        public Song()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Song"/>.
        /// </summary>
        /// <param name="name">Название. Должно быть написано на латинице 
        /// и иметь длину в диапазоне от 0 до 50 символов.</param>
        /// <param name="performer">Название исполнителя. Далжно быть написано на латинице
        /// и иметь длину в диапазоне от 0 до 50 символов.</param>
        /// <param name="duration">Длительность в секундах. Должна быть в диапазоне от 0 до 7200.</param>
        /// <param name="genre">Жанр.</param>
        public Song(string name, string performer, int duration, string genre)
        {
            this.Name = name;
            this.Performer = performer;
            this.Duration = duration;
            this.Genre = genre;
        }

        /// <summary>
        /// Переопределение метода ToString() для класса <see cref="Song"/>.
        /// </summary>
        /// <returns>Строка: "Название песни - Название исполнителя".</returns>
        public override string ToString()
        {
            return $"{Name} - " +
                $"{Performer}";
        }

        /// <summary>
        /// Клонирование объекта класса для редактирования его через TextBox.
        /// </summary>
        /// <returns>Клонированный объект класса.</returns>
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
