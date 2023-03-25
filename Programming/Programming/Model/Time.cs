using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Time
    {
        private int Hours
        {
            set
            {
                if (value < 0 || value > 23)
                    throw new ArgumentException("Недопустимое значение");
                else
                    Hours = value;
            }
        }
        private int Minutes
        {
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentException("Недопустимое значение");
                else
                    Minutes = value;
            }
        }
        private int Seconds
        {
            set
            {
                if (value < 0 || value > 59)
                    throw new ArgumentException("Недопустимое значение");
                else
                    Seconds = value;
            }
        }
    }
}
