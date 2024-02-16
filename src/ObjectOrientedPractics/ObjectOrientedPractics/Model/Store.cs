using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Model
{
    internal class Store
    {
        /// <summary>
        /// Список товаров.
        /// </summary>
        List<Item> _items = new List<Item>();

        /// <summary>
        /// Список покупателей.
        /// </summary>
        List<Customer> _customers = new List<Customer>();

        /// <summary>
        /// Возвращает и задает список товаров.
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
        /// Возвращает и задает список покупателей.
        /// </summary>
        public List<Customer> Customers
        {
            get
            {
                return _customers;
            }
            set
            {
                _customers = value;
            }
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса Store.
        /// </summary>
        public Store()
        {

        }
    }
}
