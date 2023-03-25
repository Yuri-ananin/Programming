using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Modelфильм
{
    class Movie
    {
        private string Name { get; set; }
        private int duration_in_minutes
        {
            set
            {
                if(value < 0)
                    throw new ArgumentException("Недопустимое значение");
                else
                    duration_in_minutes = value;
            }
        }
        private int year_of_issue
        {
            set
            {
                if (value < 1900 || value > 2023)
                    throw new ArgumentException("Недопустимое значение");
                else
                    year_of_issue = value;
            }
        }
        private string genre { get; set; }
        private double rating
        {
            set
            {
                if (value < 0 || value > 10)
                    throw new ArgumentException("Недопустимое значение");
                else
                    rating = value;
            }
        }
    }
}
