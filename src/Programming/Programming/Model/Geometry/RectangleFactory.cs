using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Geometry
{
    /// <summary>
    /// Класс, описывающий генерацию прямоугольников со случайными параметрами.
    /// </summary>
    class RectangleFactory
    {
        /// <summary>
        /// Метод, создающий прямоугольник со случайными параметрами.
        /// </summary>
        /// <returns>Новый прямоугольник со случайными длиной, шириной и координатами центра.</returns>
        public Rectangle Randomize()
        {
            Random random = new Random();
            var point2D = new Point2D(random.Next(20, 400), random.Next(20, 400));
            return new Rectangle(random.Next(20, 100), random.Next(20, 100), point2D);
        }
    }
}
