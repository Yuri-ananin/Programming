using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Класс, описывающий методы для проверки значений.
    /// </summary>
    static internal class ValueValidator
    {
        /// <summary>
        /// Метод, который проверяет превышает ли строка необходимое количество символов.
        /// </summary>
        /// <param name="value">Строка, которую нужно проверить.</param>
        /// <param name="maxLength">Максимально допустимая длина строки.</param>
        /// <param name="propertyName">Название поля, которая содержит проверяемую строку.</param>
        public static void AssertStringOnLength(string value, int maxLength, string propertyName)
        {
            if(value.Length > maxLength)
            {
                throw new ArgumentException("{propertyName должен быть меньше {maxLength} символов");
            }
        }
    }
}
