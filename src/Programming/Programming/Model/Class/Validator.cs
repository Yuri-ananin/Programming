using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Class
{
    /// <summary>
    /// Класс, описывающий методы для проверки значений.
    /// </summary>
    static internal class Validator
    {
        /// <summary>
        /// Метод, который проверяет число на положительность.
        /// </summary>
        /// <param name="value">Число, которое нужно проверить.</param>
        public static void AssertOnPositiveValue(int value)
        {
            if(value < 0)
            {
                throw new ArgumentException("Число не является положительным");
            }
        }
        
        /// <summary>
        /// Метод, который проверяет число на положительность.
        /// </summary>
        /// <param name="value">Число, которое нужно проверить.</param>
        public static void AssertOnPositiveValue(double value)
        {
            if(value < 0)
            {
                throw new ArgumentException("Число не является положительным");
            }
        }

        /// <summary>
        /// Метод, который проверяет лежит ли число в нужном интервале.
        /// </summary>
        /// <param name="value">Число, которое нужно проверить.</param>
        /// <param name="min">Минимально допустимое значение числа.</param>
        /// <param name="max">Максимально допустимое значение числа.</param>
        public static void AssertValueInRange(int value, int min, int max)
        {
            if(value < min || value > max)
            {
                throw new ArgumentException("Число не входит в диапазон допустимых значений");
            }
        }

        /// <summary>
        /// Метод, который проверяет лежит ли число в нужном интервале.
        /// </summary>
        /// <param name="value">Число, которое нужно проверить.</param>
        /// <param name="min">Минимально допустимое значение числа.</param>
        /// <param name="max">Максимально допустимое значение числа.</param>
        public static void AssertValueInRange(double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException("Число не входит в диапазон допустимых значений");
            }
        }
    }
}
