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
            if(value != null)
            {
                if (value.Length > maxLength)
                {
                    throw new ArgumentException("{propertyName} должен быть меньше {maxLength} символов");
                }
            }
        }

        /// <summary>
        /// Проверяет вещественное число на нахождение в диапазоне.
        /// </summary>
        /// <param name="value"> Проверяемое число. </param>
        /// <param name="maxValue"> Максимальное значение.</param>
        /// <param name="maxValue"> Минимальное значение. </param>
        /// <param name="propertyName"> Название проверяемого поля. </param>
        public static void AssertDoubleInRange(double value, double maxValue, double minValue, string propertyName)
        {
            if (value > maxValue || value < minValue)
            {
                throw new ArgumentException($"{propertyName} не может быть меньше {minValue} и больше {maxValue}.");
            }
        }

        /// <summary>
        /// Проверка целочисленного значения на нахождение в интервале.
        /// </summary>
        /// <param name="value">Передаваемое значение.</param>
        /// <param name="min">Минимально значение.</param>
        /// <param name="max">Максимальное значение.</param>
        /// <param name="propertyName">Сообщение об ошибке.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value != null)
            {
                if (value < min || value > max)
                {
                    throw new ArgumentException(propertyName);
                }
            }
        }
    }
}
