using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ObjectOrientedPractics.Model
{
    interface IDiscount
    {
        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        string Info { get; }

        /// <summary>
        /// Метод, который считает размер скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        double Calculate(List<Item> items);

        /// <summary>
        /// Метод, который применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки с вычетом накопленных баллов.</returns>
        double Apply(List<Item> items);

        /// <summary>
        /// Метод, который накапливает скидку или списывает баллы.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        void Update(List<Item> items);
    }
}
