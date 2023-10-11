using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Class;
namespace Programming.Model
{
    /// <summary>
    /// Класс, описывающий учебную дисциплину.
    /// </summary>
    internal class Subject
    {
        /// <summary>
        /// Продолжительность изучения дисциплины в часах.
        /// </summary>
        private int _learnTime;

        /// <summary>
        /// Оценка за дисциплину в зачетной книжке.
        /// </summary>
        private int _mark;

        /// <summary>
        /// Возвращает и задает название учебной дисциплины.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает продолжительность изучения дисциплины в часах. Должна быть положительным числом.
        /// </summary>
        public int LearnTime
        {
            get
            {
                return _learnTime;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _learnTime = value;
            }
        }

        /// <summary>
        /// Возвращает и задает оценку за дисциплину в зачетной книжке. Должна быть числом в диапазоне от 2 до 5.
        /// </summary>
        public int Mark
        {
            get
            {
                return _mark;
            }
            set
            {
                Validator.AssertValueInRange(value, 2, 5);
                _mark = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Subject"/>.
        /// </summary>
        public Subject()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Subject"/>.
        /// </summary>
        /// <param name="learnTime">Продолжительность изучения дисциплины в часах. Должна быть положительным числом.</param>
        /// <param name="mark">Оценка по дисциплине в зачетной книжке. Должна быть в диапазоне от 2 до 5.</param>
        /// <param name="name">Название учебной дисциплины.</param>
        public Subject(int learnTime, int mark, string name)
        {
            Name = name;
            LearnTime = learnTime;
            Mark = mark;
        }
    }
}
