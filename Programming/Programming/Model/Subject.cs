using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Subject
    {
        private string Name { get; set; }
        private int Grade
        {
            set
            {
                if (value < 2 || value > 5)
                    throw new ArgumentException("Недопустимое значение");
                else
                    Grade = value;
            }
        }
    }
}
