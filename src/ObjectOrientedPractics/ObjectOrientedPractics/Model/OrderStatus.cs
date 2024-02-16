using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    public enum OrderStatus
    {
        /// <summary>
        /// Новый заказ.
        /// </summary>
        New,

        /// <summary>
        /// Зака обрабатывается.
        /// </summary>
        Processing,

        /// <summary>
        /// Заказ собирается на складе.
        /// </summary>
        Assembly,

        /// <summary>
        /// Заказ отправлен.
        /// </summary>
        Sent,

        /// <summary>
        /// Заказ доставлен.
        /// </summary>
        Delivered,

        /// <summary>
        /// Возврат заказа.
        /// </summary>
        Returned,

        /// <summary>
        /// Заказ отменен(со стороны магазина).
        /// </summary>
        Abandoned
    }
}
