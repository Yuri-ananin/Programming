using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Song
    {
        private string Name { get; set; }
        private string Artist { get; set; }
        private int Duration_in_minutes
        {
            set
            {
                if (value < 0)
                    throw new ArgumentException("Недопустимое значение");
                else
                    Duration_in_minutes = value;
            }
        }
    }
}
