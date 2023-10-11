using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SongsListApp.Model.Classes
{
    /// <summary>
    /// Класс, описывающий методы для проверки входящих значений.
    /// </summary>
    internal class Validator
    {   
        /// <summary>
        /// Метод, который проверяет число на вхождение в заданный диапазон.
        /// </summary>
        /// <param name="value">Число, которое нужно проверить.</param>
        /// <param name="min">Минимальная граница диапазона.</param>
        /// <param name="max">Максимальная граница диапазона.</param>
        /// <exception cref="ArgumentException"></exception>
        public static void AssertValueInRange(int value, int min, int max)
        {
            if ((value < min) || (value > max))
            {
                throw new ArgumentException("Число не входит в заданный диапазон.");
            }
        }

        /// <summary>
        /// Метод, который проверяет состоит ли входящая строка только из латиницы.
        /// </summary>
        /// <param name="value">Строка, которую нужно проверить.</param>
        /// <returns>True or false.</returns>
        public static bool CheckStringContainsOnlyEnglishLetters(string? value)
        {
            bool flag = true;
            foreach (char c in value)
            {
                if (!(((c >= 'a') && (c <= 'z')) || ((c >= 'A') && (c <= 'Z')) || (c == ' ')))
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

    }
}
