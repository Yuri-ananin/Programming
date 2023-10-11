using ObjectOrientedPractics.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс описывающий покупателя.
    /// </summary>
    internal class Customer: ICloneable
    {

        /// <summary>
        /// Id покупателя.
        /// </summary>
        private int _id;

        /// <summary>
        /// Счётчик покупателей.
        /// </summary>
        private static int _counter = 0;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки для покупателя.
        /// </summary>
        private string _address;

        /// <summary>
        /// Возвращает и задает Id покупателя.
        /// </summary>
        [JsonProperty("Id")]
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
        /// Возвращает и задает полное имя покупателя.
        /// </summary>
        public string Fullname
        {
            get
            {
                return _fullname;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 200, "Fullname");
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес доставки для покупателя.
        /// </summary>
        public string Address
        {
            get
            {
                return _address;
            }
            set
            {
                ValueValidator.AssertStringOnLength(value, 500, "Address");
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задает счетчик покупателей.
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
        /// Создает пустой экземпляр класса <see cref="Customer"/>.
        /// </summary>
        public Customer()
        {

        }


        /// <summary>
        /// Создает экземпляр класса <see cref="Customer"/>.
        /// </summary>
        /// <param name="fullname">Полное имя покупателя. 
        /// Должно содержать менее 200 символов</param>
        /// <param name="address">Адрес доставки для покупателя. 
        /// Должен содержать менее 500 символов</param>
        public Customer(string fullname, string address)
        {
            _fullname = fullname;  
            _address = address;
            _counter++;
            Id = _counter;
        }

        /// <summary>
        /// Переопределение метода ToString() для класса<see cref="Customer"/>.
        /// </summary>
        /// <returns>Строка: "Id / Полное имя / Адрес".</returns>
        public override string ToString()
        {
            return $"{Id} " +
                $"/ {Fullname} " + $"/ {Address} ";
        }

        /// <summary>
        /// Клонирование объекта класса для его редактирования через TextBox.
        /// </summary>
        /// <returns>Клонированный объект класса.</returns>
        public object Clone()
        {
            return MemberwiseClone();
        }

        
    }
}
