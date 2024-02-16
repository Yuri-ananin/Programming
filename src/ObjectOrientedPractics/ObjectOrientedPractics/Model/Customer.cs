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
        /// Id покупателя.
        /// </summary>
        private int _id;

        /// <summary>
        /// Счётчик для <see cref="Customer"/>.
        /// </summary>
        private static int _idCounter = 0;

        /// <summary>
        /// Полное имя покупателя.
        /// </summary>
        private string _fullname;

        /// <summary>
        /// Адрес доставки для покупателя.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Корзина товаров покупателя.
        /// </summary>
        private Cart _cart = new Cart();

        /// <summary>
        /// Список заказов покупателя.
        /// </summary>
        private List<Order> _orders = new List<Order>();

        /// <summary>
        /// Возвращает id покупателя.
        /// </summary>
        [JsonProperty(nameof(Id))]
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
        /// Возвращает и задает список заказов покупателя.
        /// </summary>
        public List<Order> Orders
        {
            get
            {
                return _orders;
            }
            set
            {
                _orders = value;
            }
        }

        /// <summary>
        /// Возвращает и задает корзину товаров покупателя.
        /// </summary>
        public Cart Cart
        {
            get
            {
                return _cart;
            }
            set
            {
                _cart = value;
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
        /// Возвращает и задаёт счетчик покупателей.
        /// </summary>
        public int IdCounter
        {
            get
            {
                return _idCounter;
            }
            set
            {
                _idCounter = value;
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
        public Customer(string fullname, Address address)
        {
            Fullname = fullname;  
            Address = address;
            IdCounter++;
            Id = _idCounter;
            Cart = new Cart();
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
