using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    class Contact
    {
        private string Name { get; set; }
        private string Surname { get; set; }
        private int Number
        {
            set
            {
                if (value < 80000000000 || value > 89999999999)
                    throw new ArgumentException("Недопустимое значение");
                else
                    Number = value;
            }
        }
    }
}
