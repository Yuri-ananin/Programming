using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Rectangle
    {
        private double Length
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException("Недопустимое значение");
                else
                    Length = value;
            }
        }
        private double Width
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException("Недопустимое значение");
                else
                    Width = value;
            }
        }
        private string Color { get; set; }
    }
}
