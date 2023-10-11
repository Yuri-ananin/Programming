using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Class;
namespace Programming.Model
{
    /// <summary>
    /// Класс, описывающий геометрическое кольцо.
    /// </summary>
    class Ring
    {
        /// <summary>
        /// Внутренний радиус.
        /// </summary>
        private double _internalRadius;

        /// <summary>
        /// Внешний радиус.
        /// </summary>
        private double _externalRadius;

        /// <summary>
        /// Возвращает и задает внутренний радиус. Должен быть положительным числом.
        /// </summary>
        public double InternalRadius
        {
            get
            {
                return _internalRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _internalRadius = value;
            }
        }

        /// <summary>
        /// Возвращает и задает внешний радиус. Должен быть положительным числом. Должен быть больше или равен внутреннему радиусу.
        /// </summary>
        public double ExternalRadius
        {
            get
            {
                return _externalRadius;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                if(!(value >= _internalRadius))
                {
                    throw new ArgumentException("Ошибка в задании радиуса");
                }
                _externalRadius = value;
            }
        }
        
        /// <summary>
        /// Возвращает площадь кольца.
        /// </summary>
        public double Area
        {
            get
            {
                var internalArea = _internalRadius * _internalRadius * Math.PI;
                var externalArea = _externalRadius * _externalRadius * Math.PI;
                return externalArea - internalArea;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Ring"/>.
        /// </summary>
        public Ring()
        {

        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Ring"/>.
        /// </summary>
        /// <param name="internalRadius">Внутренний радиус. Должен быть положительным числом.</param>
        /// <param name="externalRadius">Внешний радиус. Должен быть положительным числом. Должен быть больше либо равен внутреннему радиусу.</param>
        public Ring(double internalRadius, double externalRadius)
        {
            this.InternalRadius = internalRadius;
            this.ExternalRadius = externalRadius;
        }
    }
}
