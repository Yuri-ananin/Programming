using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий товар.
    /// </summary>
    class Item: ICloneable, IEquatable<Item>, IComparable<Item>
    {
        /// <summary>
        /// Id товара.
        /// </summary>
        private int _id;

        /// <summary>
        /// Наименование товара.
        /// </summary>
        private string _name;

        /// <summary>
        /// Описание товара.
        /// </summary>
        private string _info;

        /// <summary>
        /// Цена товара.
        /// </summary>
        private double _cost;

        /// <summary>
        /// Счётчик товаров.
        /// </summary>
        private static int _counter = 0;

        /// <summary>
        /// Возвращает и задает категорию товара.
        /// </summary>
        public Category Category { get; set; }

        /// <summary>
        /// Возвращает и задает Id товара.
        /// </summary>
        public int Id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }

        /// <summary>
        /// Возвращает и задает Наименование товара.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, nameof(Name));
                _name = value;
            }
        }

        /// <summary>
        /// Возвращает и задает Описание товара.
        /// </summary>
        public string Info
        {
            get
            {
                return _info;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 1000, nameof(Info));
                _info = value;
            }
        }

        /// <summary>
        /// Возвращает и задает Цену товара.
        /// </summary>
        public double Cost
        {
            get
            {
                return _cost;
            }
            set
            {
                ValueValidator.AssertDoubleInRange(value, 100_000.0, 0.0, "Cost");
                _cost = value;
            }
        }

        /// <summary>
        /// Возвращает и задает счетчик товаров.
        /// </summary>
        public int Counter
        {
            get
            {
                return _counter;
            }
            set
            {
                _counter = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса<see cref="Item"/>
        /// </summary>
        public Item()
        {

        }

        /// <summary>
        /// Создает экземпляр класса<see cref="Item"/>
        /// </summary>
        /// <param name="name">Наименование товара. Должно содержать менее 200 символов.</param>
        /// <param name="info">Описание товара. Должно содержать менне 1000 символов.</param>
        /// <param name="cost">Цена товара. Должна быть в диапазоне от 0 до 100000.</param>
        /// <param name="category">Категория товара.</param>
        public Item(string name, string info, double cost, Category category) 
        {
            Name = name;
            Info = info;
            Cost = cost;
            Category = category;
            Counter++;
            Id = _counter;
        }

        /// <summary>
        /// Переопределение метода ToString() для класса<see cref="Item"/>.
        /// </summary>
        /// <returns>Строка: "Id / Наименование / Описание / Цена".</returns>
        public override string ToString()
        {
            return $"{Id} " +
                $"/ {Name} " + $"/ {Info} " + $"/ {Cost}";
        }

        /// <summary>
        /// Клонирование объекта класса для его редактирования через TextBox.
        /// </summary>
        /// <returns>Клонированный объект класса</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }

        /// <summary>
        /// <inheritdoc cref="IEquatable<Address>"/>
        /// </summary>
        /// <param name="other">Сравниваемая переменная типа <see cref="Item"/>.</param>
        /// <returns>True - если они равны. False - не равны.</returns>
        public bool Equals(Item other)
        {
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }

            if (this.Name != other.Name || this.Info != other.Info
                || this.Cost != other.Cost || this.Category != other.Category)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        /// <summary>
        /// <inheritdoc cref="IComparable"/>
        /// </summary>
        /// <param name="other">Сравниваемая переменная типа <see cref="Item"/>.</param>
        /// <returns>1 - больше или null сравниваемый объект. 0 - они равны.
        /// -1 - сравниваемый больше.</returns>
        public int CompareTo(Item? other)
        {
            if (other == null)
            {
                return 1;
            }

            else
            {
                return this.Cost.CompareTo(other.Cost);
            }
        }

        /// <summary>
        /// Генерирует случайный товар.
        /// </summary>
        /// <returns>Случайный товар.</returns>
        public static Item GenerateRandomItem()
        {
            Random random = new Random();
            string name = $"Item ({_counter + 1}).";
            string info = "Info about item.";
            int cost = random.Next(0, 10000);
            Category category = (Category)random.Next(0,
                Enum.GetNames(typeof(DesiredDeliveryTime)).Length);
            return new Item(name, info, cost, category);
        }
    }
}
