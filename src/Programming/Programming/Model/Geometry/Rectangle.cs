using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Programming.Model.Class;
namespace Programming.Model
{   
    /// <summary>
    /// Класс описывающий треугольник.
    /// </summary>
    internal class Rectangle
    {
        /// <summary>
        /// Длина.
        /// </summary>
        private double _length;

        /// <summary>
        /// Ширина.
        /// </summary>
        private double _width;

        /// <summary>
        /// Счетчик прямоугольников.
        /// </summary>
        private static int _allRectanglesCount = 0;

        /// <summary>
        /// Id прямоугольника.
        /// </summary>
        private int _id;

        /// <summary>
        /// Возвращает и задает цвет прямоугольника.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        /// Возвращает и задает длину прямоугольника. Должна быть положительным числом.
        /// </summary>
        public double Length
        {
            get
            {
                return _length;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _length = value;
            }
        }

        /// <summary>
        /// Возвращает и задает ширину прямоугольника. Должна быть положительным числом.
        /// </summary>
        public double Width
        {
            get
            {
                return _width;
            }
            set
            {
                Validator.AssertOnPositiveValue(value);
                _width = value;
            }
        }

        /// <summary>
        /// Возвращает и задает количество прямоугольников.
        /// </summary>
        public int AllRectanglesCount
        {
            get
            {
                return _allRectanglesCount;
            }
            private set
            {
                AllRectanglesCount = value; 
            }
        }

        /// <summary>
        /// Возвращает и задает Id прямоугольника.
        /// </summary>
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
        /// Возвращает и задает центр прямоугольника.
        /// </summary>
        public Point2D Center { get; set; }
        
        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        public Rectangle()
        {
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Длина прямоугольника. Должна быть положительным числом.</param>
        /// <param name="width">Ширина прямоугольника. Должна быть положительным числом.</param>
        /// <param name="center">Координаты центра прямоугольника.</param>
        public Rectangle(double length, double width, Point2D center)
        {
            this.Length = length;
            this.Width = width;
            this.Center = center;
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="Rectangle"/>.
        /// </summary>
        /// <param name="length">Длина прямоугольника. Должна быть положительным числом.</param>
        /// <param name="width">Ширина прямоугольника. Должна быть положительным числом.</param>
        /// <param name="color">Цвет прямоугольника.</param>
        /// <param name="center">Координаты центра прямоугольника.</param>
        public Rectangle(double length, double width, string color, Point2D center)
        {
            this.Length = length;
            this.Width = width;
            this.Color = color;
            this.Center = center;
            _allRectanglesCount++;
            Id = _allRectanglesCount;
        }
    }
}
