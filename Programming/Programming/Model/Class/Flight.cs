using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Flight
    {
        

        public string DeparturePoint { get; set; }

        public string Destination { get; set; }
        private int _flightTimeMinute;
        public int FlightTimeMinute
        {
            get
            {
                return _flightTimeMinute;
            }
            set
            {
                if (value > 0)
                {
                    _flightTimeMinute = value;
                }
            }
        }

        public Flight()
        {

        }

        public Flight(string departurePoint, string destination, int flightTimeMinute)
        {
            this.DeparturePoint = departurePoint;
            this.Destination = destination;
            this.FlightTimeMinute = flightTimeMinute;
        }
    }
}
