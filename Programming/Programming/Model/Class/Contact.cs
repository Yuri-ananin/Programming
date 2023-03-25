using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    internal class Contact
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        private int _number;

        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if(_number.ToString().Length == 11)
                {
                    _number = value;
                }
            }
        }

        public Contact()
        {

        }
        
        public Contact(string name, string surname, int number)
        {
            this.Name = name;
            this.Surname = surname;
            this.Number = number;
        }
    }
}
