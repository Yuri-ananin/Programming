using Newtonsoft.Json;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс описывающий покупателя.
    /// </summary>
    internal class Customer: ICloneable
    {
        /// <summary>
        /// Счётчик для <see cref="Customer"/>.
        /// </summary>
        private static int _counter = 0;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки для покупателя.
        /// </summary>
        private Address _address = new Address();

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
                ValueValidator.AssertStringOnLength(value, 200, nameof(Fullname));
                _fullname = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес доставки для покупателя.
        /// </summary>
        public Address Address
        {
            get
            {
                return _address;
            }
            set
            {
                _address = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт счётчик покупателей.
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
        /// Возвращает и задает Id покупателя.
        /// </summary>
        [JsonProperty(nameof(Id))]
        public int Id { get; private set; }

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
        public Customer(string fullname, Address address)
        {
            Fullname = fullname;  
            Address = address;
            Counter++;
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
