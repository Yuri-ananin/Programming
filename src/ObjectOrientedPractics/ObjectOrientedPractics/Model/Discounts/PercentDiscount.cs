using Newtonsoft.Json.Linq;
using ObjectOrientedPractics.Model.Enums;
using ObjectOrientedPractics.Services;

namespace ObjectOrientedPractics.Model.Discounts
{
    class PercentDiscount : IDiscount, IComparable<PercentDiscount>
    {
        /// <summary>
        /// Текущая категория товара.
        /// </summary>
        public Category DiscountCategory;

        /// <summary> 
        /// Текущая стоимость товаров.
        /// </summary>
        private double _amount = 0;

        /// <summary>
        /// Текущее значение скидки.
        /// </summary>
        private double _currentDiscount = 0.01;

        /// <summary>
        ///Возвращает и задаёт текущее значение скидки. Не более 0.1 (10%).
        /// </summary>
        public double CurrentDiscount
        {
            get => _currentDiscount;
            set
            {
                if (value > 0.1)
                {
                    _currentDiscount = 0.1;
                }
                else
                    _currentDiscount = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт текущую стоимость товаров.
        /// </summary>
        private double Amount
        {
            get => _amount;
            set
            {
                _amount = value;
            }
        }

        /// <summary>
        /// Метод, который считает размер скидки.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            Amount = 0;

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Category == DiscountCategory)
                {
                    Amount += items[i].Cost;
                }
            }

            return Amount * CurrentDiscount;
        }

        /// <summary>
        /// Метод применяющий скидку для товаров заданной категории.
        /// </summary>
        /// <param name="items"><Список товаров./param>
        /// <returns>Размер скидки.</returns>
        public double Apply(List<Item> items)
        {

            double discount = Calculate(items);
            
            return discount;
        }

        /// <summary>
        /// Метод, который накапливает скидку для товаров заданной категории.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            Amount = items.Sum(item => item.Cost);

            if (Amount / 1000 >= 1d)
            {
                CurrentDiscount += Amount / 1000 / 100d;
            }
        }

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get => $"«Процентная «{DiscountCategory}» - {Math.Floor(_currentDiscount * 100)}%";
        }

        /// <summary>
        /// <inheritdoc cref="IComparable"/>
        /// </summary>
        /// <param name="other">Сравниваемая переменная типа <see cref="PercentDiscount"/>.</param>
        /// <returns>1 - больше или null сравниваемый объект. 0 - они равны. -1 - сравниваемый больше.</returns>
        public int CompareTo(PercentDiscount other)
        {
            if (other == null)
            {
                return 1;
            }

            else
            {
                return this.CurrentDiscount.CompareTo(other.CurrentDiscount);
            }
        }
    }
}
