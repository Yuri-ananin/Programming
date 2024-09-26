namespace ObjectOrientedPractics.Model.Discounts
{
    class PointsDiscount : IDiscount
    {
        /// <summary>
        /// Количество баллов.
        /// </summary>
        private int _pointsCounter = 0;

        /// <summary>
        /// Задаёт и возвращает количество баллов.
        /// </summary>
        public int PointsCounter
        {
            get
            {
                return _pointsCounter;
            }
            private set
            {
                _pointsCounter = value;
            }
        }

        /// <summary>
        /// Метод, который считает размер скидки, доступный для корзины с товарами.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Округленный размер скидки.</returns>
        public double Calculate(List<Item> items)
        {
            double amount = 0;
            double amountWithDiscount;
            double discountSize = 0;

            for (int i = 0; i < items.Count; i++)
            {
                amount += items[i].Cost;
            }

            if (PointsCounter < amount * 0.3)
            {
                amountWithDiscount = amount - PointsCounter;
                discountSize = amount - amountWithDiscount;
            }

            else if (PointsCounter >= amount * 0.3)
            {
                amountWithDiscount = amount * 0.7;
                discountSize = amount - amountWithDiscount;
            }

            return Convert.ToInt32(discountSize);
        }

        /// <summary>
        /// Метод, который применяет скидку к товарам.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        /// <returns>Размер скидки с вычетом накопленных баллов.</returns>
        public double Apply(List<Item> items)
        {
            double amount = items.Sum(item => item.Cost);
            PointsCounter += Convert.ToInt32(Math.Ceiling(amount * 0.1));

            int discountAmount = Convert.ToInt32(Calculate(items));
            PointsCounter -= discountAmount;

            return discountAmount;
        }

        /// <summary>
        /// Метод, который добавляет баллы на основе полученного списка товаров.
        /// </summary>
        /// <param name="items">Список товаров.</param>
        public void Update(List<Item> items)
        {
            double amount = items.Sum(item => item.Cost);

            PointsCounter += Convert.ToInt32(Math.Ceiling(amount * 0.1));
        }

        /// <summary>
        /// Возвращает информацию о скидке.
        /// </summary>
        public string Info
        {
            get => $"«Накопительная – {PointsCounter} баллов";
        }
    }
}
