using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Class;
namespace Programming.Model
{
    /// <summary>
    /// Класс, описывающий время.
    /// </summary>
    internal class Time
    {
        /// <summary>
        /// Количество часов.
        /// </summary>
        private int _hours;

        /// <summary>
        /// Количество минут.
        /// </summary>
        private int _minutes;

        /// <summary>
        /// Количество секунд.
        /// </summary>
        private int _seconds;

        /// <summary>
        /// Возвращает и задает количество часов. Должно быть числом в диапазоне от 0 до 23.
        /// </summary>
        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 23);
                _hours = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество минут. Должно быть числом в диапазоне от 0 до 59.
        /// </summary>
        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 59);
                _minutes = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество секунд. Должно быть числом в диапазоне от 0 до 59.
        /// </summary>
        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                Validator.AssertValueInRange(value, 0, 59);
                _seconds = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Time"/>.
        /// </summary>
        public Time()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Time"/>.
        /// </summary>
        /// <param name="seconds">Количество секунд. Должно быть числом в диапазоне от 0 до 59.</param>
        /// <param name="minutes">Количество минут. Должно быть числом в диапазоне от 0 до 59.</param>
        /// <param name="hours">Количество часов. Должно быть числом в диапазоне от 0 до 23.</param>
        public Time(int seconds, int minutes, int hours)
        {
            this.Seconds = seconds;
            this.Minutes = minutes;
            this.Hours = hours;
        }
    }
}
