using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Flight
    {
        private string departure_point { get; set; }
        private string destination { get; set; }
        private int flight_time_in_minutes
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException("Недопустимое значение");
                else
                    flight_time_in_minutes = value;
            }
        }
    }
}
