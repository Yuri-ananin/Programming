using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Class;
namespace Programming.Model
{
    /// <summary>
    /// Класс, описывающий местоположение центра геометрической фигуры на плоскости.
    /// </summary>
    class Point2D
    {
        /// <summary>
        /// Координата X.
        /// </summary>
        private double _x;

        /// <summary>
        /// Координата Y.
        /// </summary>
        private double _y;

        /// <summary>
        /// Возвращает и задаёт координату X. Должна быть положительным числом.
        /// </summary>
        public double X
        {
            get
            {
                return _x;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _x = value;
            }
        }

        /// <summary>
        /// Возвращает и задает координату Y. Должна быть положительным числом.
        /// </summary>
        public double Y
        {
            get
            {
                return _y;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _y = value;
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        public Point2D()
        {

        }
        
        /// <summary>
        /// Создает экземпляр класса <see cref="Point2D"/>.
        /// </summary>
        /// <param name="x">Координата X. Должна быть положительным числом.</param>
        /// <param name="y">Координата Y. Должна быть положительным числом.</param>
        public Point2D(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

    }
}
