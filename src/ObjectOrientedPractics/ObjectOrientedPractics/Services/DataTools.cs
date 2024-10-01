using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model;
using ObjectOrientedPractics.Model.Enums;

internal delegate bool CompareValues(Item x1, Item x2);

namespace ObjectOrientedPractics.Services
{
    internal class DataTools
    {
        /// <summary>
        /// Возвращает и задаёт значение для поиска в списке товаров.
        /// </summary>
        internal static string FilterNamePrincipleOfVerification { get; set; }

        /// <summary>
        /// Фильтрация по введённому значению <see cref="FilterNamePrincipleOfVerification"/>.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <param name="filter">Принцип фильтрации.</param>
        /// <returns>Список с подходящими элементами.</returns>
        internal static List<Item> ItemsFiltred(List<Item> items, Func<Item, bool> filter)
        {
            List<Item> filtredList = new List<Item>();

            foreach (Item item in items)
            {
                if (filter(item))
                {
                    filtredList.Add(item);
                }
            }
            return filtredList;
        }

        /// <summary>
        /// Фильтрация по стоимости выше 5000.
        /// </summary>
        /// <param name="item">Товар <see cref="Item"/>.</param>
        /// <returns>True - товар стоит выше 5000. Иначе False.</returns>
        internal static bool ItemFilterByCost(Item item)
        {
            return item.Cost > 5000;
        }

        /// <summary>
        /// Фильтрация по категорию Shoes.
        /// </summary>
        /// <param name="item">Товар <see cref="Item"/>.</param>
        /// <returns>True - товар категории обувь. Иначе False.</returns>
        internal static bool ItemFilterByShoesCategory(Item item)
        {
            return item.Category == Category.Shoes;
        }

        /// <summary>
        /// Фильтрация по имени товара.
        /// </summary>
        /// <param name="item">Товар <see cref="Item"/>.</param>
        /// <returns>Содержится ли искомая строка
        /// <see cref="FilterNamePrincipleOfVerification"/> в именовании.</returns>
        internal static bool ItemFilterByName(Item item)
        {
            if (string.IsNullOrEmpty(item.Name) ||
                string.IsNullOrEmpty(FilterNamePrincipleOfVerification))
            {
                return false;
            }

            return (item.Name.Contains(FilterNamePrincipleOfVerification));
        }

        /// <summary>
        /// Сравнение 2-х товаров по именованию.
        /// </summary>
        /// <param name="x1">Товар 1<see cref="Item"/>.</param>
        /// <param name="x2">Товар 2<see cref="Item"/>.</param>
        /// <returns>True - 1-й меньше второго. Иначе False.</returns>
        internal static bool CompareName(Item x1, Item x2)
        {

            return x2.Name.CompareTo(x1.Name) >= 0;
        }

        /// <summary>
        /// Сравнение 2-х товаров по возрастанию цены.
        /// </summary>
        /// <param name="x1">Товар 1<see cref="Item"/>.</param>
        /// <param name="x2">Товар 2<see cref="Item"/>.</param>
        /// <returns>True - 1-й больше второго. Иначе False.</returns>
        internal static bool CompareAscending(Item x1, Item x2)
        {
            return x1.Cost < x2.Cost;
        }

        /// <summary>
        /// Сравнение 2-х товаров по убыванию цены.
        /// </summary>
        /// <param name="x1">Товар 1<see cref="Item"/>.</param>
        /// <param name="x2">Товар 2<see cref="Item"/>.</param>
        /// <returns></returns>
        internal static bool CompareDescending(Item x1, Item x2)
        {
            return x1.Cost > x2.Cost;
        }

        /// <summary>
        /// Сортировка списка товаров по разным приницпам.
        /// </summary>
        /// <param name="values">Список товаров.</param>
        /// <param name="compare">Принцип сравнения.</param>
        /// <returns>Отсортированный список.</returns>
        internal static List<Item> Sort(List<Item> values, CompareValues compare)
        {
            for (int i = 0; i < values.Count; i++)
            {
                for (int j = 1; j < values.Count; j++)
                {
                    if (compare(values[j], values[j - 1]))
                    {
                        Item temp = values[j];
                        values[j] = values[j - 1];
                        values[j - 1] = temp;
                    }
                }
            }
            return values;
        }
    }
}
