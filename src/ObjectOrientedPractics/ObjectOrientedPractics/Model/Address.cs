using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, который описывает адрес доставки покупателю.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Почтовый индекс.
        /// </summary>
        private int _index = new int();

        /// <summary>
        /// Страна.
        /// </summary>
        private string _country;

        /// <summary>
        /// Город.
        /// </summary>
        private string _city;

        /// <summary>
        /// Улица.
        /// </summary>
        private string _street;

        /// <summary>
        /// Номер дома.
        /// </summary>
        private string _building;

        /// <summary>
        /// Номер квартиры
        /// </summary>
        private string _apartment;

        /// <summary>
        /// Возвращает и задает почтовый инедекс.
        /// </summary>
        public int Index
        {
            get
            {
                return _index;
            }
            set
            {
                if (value != null && value != 0)
                {
                    ValueValidator.AssertValueInRange(value, 100000, 999999, "Неверное значение почтового индекса." + " Шестизначное число.");
                    _index = value;
                }
            }
        }

        /// <summary>
        /// Возвращает и задает страну.
        /// </summary>
        public string Country
        {
            get
            {
                return _country;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(Country));
                _country = value;
            }
        }

        /// <summary>
        /// Возвращает и задает город.
        /// </summary>
        public string City
        {
            get
            {
                return _city;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 50, nameof(City));
                _city = value;
            }
        }

        /// <summary>
        /// Возвращает и задает улицу.
        /// </summary>
        public string Street
        {
            get
            {
                return _street;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 100, nameof(Street));
                _street = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер дома.
        /// </summary>
        public string Building
        {
            get
            {
                return _building;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Building));
                _building = value;
            }
        }

        /// <summary>
        /// Возвращает и задает номер квартиры.
        /// </summary>
        public string Apartment
        {
            get
            {
                return _apartment;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 10, nameof(Apartment));
                _apartment = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса<see cref="Address"/>.
        /// </summary>
        public Address()
        {

        }

        /// <summary>
        /// Создает экземпляр класса<see cref="Address"/>.
        /// </summary>
        /// <param name="index">Почтовый индекс. Целое шестизначное число.</param>
        /// <param name="country">Страна/регион. Длина не более 50 символов.</param>
        /// <param name="city">Город(населенный пункт). Длина не более 50 символов.</param>
        /// <param name="street">Улица. Длина не более 100 символов.</param>
        /// <param name="building">Номер дома. Длина не более 10 символов.</param>
        /// <param name="apartment">Номер квартиры. Длина не более 10 символов.</param>
        public Address(int index, string country, string city, string street, string building, string apartment)
        {
            Index = index;
            Country = country;
            City = city;
            Street = street;
            Building = building;
            Apartment = apartment;
        }

        /// <summary>
        /// Переопределение метода ToString() для класса <see cref="Address"/>.
        /// </summary>
        /// <returns>Строка: Index, Country, City, Street, Building, Apartment.</returns>
        public override string ToString()
        {
            return $"Index: {Index}, Country:{Country}, City:{City}, " +
                $"Street:{Street}, Building:{Building}, Apartment:{Apartment}";
        }
    }
}
