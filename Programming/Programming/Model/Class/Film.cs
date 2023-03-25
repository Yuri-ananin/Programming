using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Film
    {
        public string Name { get; set; }

        private int _duration;

        private int _year;
        public string Genre { get; set; }

        private double _rating;


        public int Duration
        {
            get
            {
                return _duration;
            }
            set
            {
                if (value > 0)
                {
                    _duration = value;
                }
            }
        }

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value < 1900 || value > 2023)
                {
                    throw new ArgumentException("Неверный год.");
                }
                else
                {
                    _year = value;
                }
            }
        }

        

        public double Rating
        {
            get
            {
                return _rating;
            }
            set
            {
                if (value > 10)
                {
                    throw new ArgumentException("Некорректный рейтинг.");
                }

                if (value > 0)
                {
                    _rating = value;
                }
            }
        }

        public Film()
        {

        }

        public Film(string name, int duration, int year, string genre, double rating)
        {
            this.Name = name;
            this.Duration = duration;
            this.Year = year;
            this.Genre = genre;
            this.Rating = rating;
        }
    }
}
