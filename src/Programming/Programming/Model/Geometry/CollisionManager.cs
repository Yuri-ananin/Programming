using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Класс, описывающий методы проверки, определяющие пересечение геометрических фигур.
    /// </summary>
    class CollisionManager
    {
        /// <summary>
        /// Метод, проверяющий пересечение двух прямоугольников.
        /// </summary>
        /// <param name="rectangle1">Первый прямоугольник.</param>
        /// <param name="rectangle2">Второй прямоугольник.</param>
        /// <returns>Возвращает true or false.</returns>
        public static bool IsCollision(Rectangle rectangle1, Rectangle rectangle2)
        {
            return (Math.Abs(rectangle1.Center.X - rectangle2.Center.X) < 
                (rectangle2.Width / 2 + rectangle1.Width / 2) &
                Math.Abs(rectangle1.Center.Y - rectangle2.Center.Y) < 
                (rectangle2.Length / 2 + rectangle1.Length / 2));    
        }

        /// <summary>
        /// Метод, проверяющий пересечение двух колец.
        /// </summary>
        /// <param name="ring1">Первое кольцо.</param>
        /// <param name="ring2">Второе кольцо.</param>
        /// <returns>Возвращает true or false.</returns>
        public static bool IsCollision(Ring ring1, Ring ring2)
        {
            double cathetus1 = Math.Pow(ring1.ExternalRadius, 2);
            double cathetus2 = Math.Pow(ring2.ExternalRadius, 2);

            double hypotenuse = Math.Sqrt(cathetus1 + cathetus2);

            return hypotenuse < (ring1.ExternalRadius + ring2.ExternalRadius);
        }
    }
}
