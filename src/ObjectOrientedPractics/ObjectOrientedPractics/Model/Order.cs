using Newtonsoft.Json;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Класс, описывающий заказ покупателя.
    /// </summary>
    internal class Order
    {
        /// <summary>
        /// Id заказа.
        /// </summary>
        private int _id;

        /// <summary>
        /// Дата создания заказа.
        /// </summary>
        private string _date;

        /// <summary>
        /// Список товаров в заказе.
        /// </summary>
        private List<Item> _items;

        /// <summary>
        /// Счетчик заказов.
        /// </summary>
        private static int _allOrdersCount = 0;

        /// <summary>
        /// Общая стоимость товаров в заказе.
        /// </summary>
        private double _amount;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Возвращает id заказа.
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
        /// Возвращает дату создания заказа.
        /// </summary>
        [JsonProperty]
        public string Date
        {
            get
            {
                return _date;
            }
            private set
            {
                _date = value;
            }
        }

        /// <summary>
        /// Возвращает и задает адрес доставки.
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
        /// Возвращает и задает список товаров в заказе.
        /// </summary>
        public List<Item> Items
        {
            get
            {
                return _items;
            }
            set
            {
                _items = value;
            }
        }

        /// <summary>
        /// Возвращает и задает общую стоимость товаров в заказе.
        /// </summary>
        public double Amount
        {
            get
            {
                return _amount;
            }
            set
            {
                _amount = value;
            }
        }

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Возвращает и задает счетчик заказов.
        /// </summary>
        public int AllOrdersCount
        {
            get
            {
                return _allOrdersCount;
            }
            set
            {
                _allOrdersCount = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Order"/>.
        /// </summary>
        public Order()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Order"/>
        /// </summary>
        /// <param name="address"> Адрес доставки.</param>
        /// <param name="cart"> Корзина с товарами. </param>
        /// <param name="orderStatus"> Статус заказа. </param>
        /// <param name="date"> Дата заказа. </param>
        public Order(Address address, Cart cart, OrderStatus orderStatus, string date)
        {
            Date = date;
            Address = address;
            Items = cart.Items;
            Amount = cart.Amount;
            OrderStatus = orderStatus;
            AllOrdersCount++;
            Id = _allOrdersCount;
        }
    }
}
