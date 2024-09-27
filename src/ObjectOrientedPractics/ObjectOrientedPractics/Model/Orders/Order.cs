using Newtonsoft.Json;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Orders
{
    /// <summary>
    /// Класс, описывающий заказ покупателя.
    /// </summary>
    internal class Order: IEquatable<Order>
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
        protected double _amount;

        /// <summary>
        /// Адрес доставки.
        /// </summary>
        private Address _address = new Address();

        /// <summary>
        /// Возвращает id заказа.
        /// </summary>
        [JsonProperty]
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
        /// Возвращает и задаёт размер примерной скидки.
        /// </summary>
        public double DiscountAmount { get; set; }

        public double Total
        {
            get
            {
                return Amount - DiscountAmount;
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
        /// Возвращает и задает общую стоимость товаров.
        /// </summary>
        public double Amount
        {
            get
            {
                if (Items == null || Items.Count == 0)
                {
                    return 0.0;
                }
                return Items.Sum(item => item.Cost);
            }
            set => _amount = value;
        }

        /// <summary>
        /// Возвращает и задает статус заказа.
        /// </summary>
        public OrderStatus OrderStatus { get; set; }

        /// <summary>
        /// Возвращает и задает счетчик заказов.
        /// </summary>
        [JsonProperty]
        public int AllOrdersCount
        {
            get
            {
                return _allOrdersCount;
            }
            private set
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
        /// <summary>
        /// <inheritdoc cref="IEquatable<Address>"/>
        /// </summary>
        /// <param name="other">Сравниваемая переменная типа <see cref="Order"/>.</param>
        /// <returns>True - если они равны. False - не равны.</returns>
        public bool Equals(Order other)
        {
            if (other == null)
            {
                return false;
            }
            if (object.ReferenceEquals(this, other))
            {
                return true;
            }
            if (this.GetType() != other.GetType())
            {
                return false;
            }
            if (this.Items == other.Items || this.Id == other.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
