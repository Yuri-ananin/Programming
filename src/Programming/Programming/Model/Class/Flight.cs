using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Class;
namespace Programming.Model
{
    /// <summary>
    /// Класс, описывающий рейс самолета.
    /// </summary>
    internal class Flight
    {
        /// <summary>
        /// Время полета в минутах.
        /// </summary>
        private int _flightTimeMinute;

        /// <summary>
        /// Возвращает и задает точку отправления.
        /// </summary>
        public string DeparturePoint { get; set; }

        /// <summary>
        /// Возвращает и задает точку прибытия.
        /// </summary>
        public string Destination { get; set; }
        
        /// <summary>
        /// Возвращает и задает длительность полета в минутах. Должна представлять собой положительное число.
        /// </summary>
        public int FlightTimeMinute
        {
            get
            {
                return _flightTimeMinute;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _flightTimeMinute = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Flight"/>.
        /// </summary>
        public Flight()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Flight"/>.
        /// </summary>
        /// <param name="departurePoint">Точка отправления.</param>
        /// <param name="destination">Точка прибытия.</param>
        /// <param name="flightTimeMinute">Продолжительность полета в минутах. Должна быть положительным числом.</param>
        public Flight(string departurePoint, string destination, int flightTimeMinute)
        {
            this.DeparturePoint = departurePoint;
            this.Destination = destination;
            this.FlightTimeMinute = flightTimeMinute;
        }
    }
}
