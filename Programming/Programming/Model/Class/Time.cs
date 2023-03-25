using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Time
    {
        private int _hours;
        private int _minutes;
        private int _seconds;

        public int Hours
        {
            get
            {
                return _hours;
            }
            set
            {
                if (value >= 0 && value < 24)
                {
                    _hours = value;
                }
            }
        }

        public int Minutes
        {
            get
            {
                return _minutes;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    _minutes = value;
                }
            }
        }

        public int Seconds
        {
            get
            {
                return _seconds;
            }
            set
            {
                if (value >= 0 && value < 60)
                {
                    _seconds = value;
                }
            }
        }

        public Time()
        {

        }

        public Time(int seconds, int minutes, int hours)
        {
            this.Seconds = seconds;
            this.Minutes = minutes;
            this.Hours = hours;
        }
    }
}
