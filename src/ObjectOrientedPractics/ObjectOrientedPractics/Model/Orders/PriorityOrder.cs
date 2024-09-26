using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObjectOrientedPractics.Model.Enums;

namespace ObjectOrientedPractics.Model.Orders
{
    class PriorityOrder : Order
    {
        /// <summary>
        /// Эелаемая дата доставки
        /// </summary>
        private DateTime _desiredDeliveryDate;

        /// <summary>
        /// Желаемое время доставки
        /// </summary>
        public DesiredDeliveryTime DesiredDeliveryTime { get; set; }

        /// <summary>
        /// Возвращает и задаёт желаемую дату доставки.
        /// </summary>
        public DateTime DesiredDeliverydate
        {
            get => _desiredDeliveryDate;
            set => _desiredDeliveryDate = value;
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="PriorityOrder"/>
        /// </summary>
        public PriorityOrder()
        {

        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="PriorityOrder"/>
        /// </summary>
        /// <param name="address"> Адрес доставки.</param>
        /// <param name="cart"> Корзина. </param>
        /// <param name="orderStatus"> Статус заказа. </param>
        /// <param name="date"> Дата создания заказа.</param>
        /// <param name="desiredDeliveryDate"> Желаемая дата доставки заказа.</param>
        /// <param name="desiredDeliveryTime"> Желаемое время доставки заказа.</param>
        public PriorityOrder(Address address, Cart cart, OrderStatus orderStatus,
            string date, DateTime desiredDeliveryDate, DesiredDeliveryTime desiredDeliveryTime)
            : base(address, cart, orderStatus, date)
        {
            DesiredDeliveryTime = desiredDeliveryTime;
            DesiredDeliverydate = desiredDeliveryDate;
        }

        public PriorityOrder(Address address, Cart cart, OrderStatus orderStatus, string date) :
            base(address, cart, orderStatus, date)
        {

        }
    }
}
