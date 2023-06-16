using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model
{
    /// <summary>
    /// Класс, описывающий контакт в телефоне.
    /// </summary>
    internal class Contact
    {
        /// <summary>
        /// Номер контакта.
        /// </summary>
        private int _number;
        
        /// <summary>
        /// Имя контакта.
        /// </summary>
        private string _name;

        /// <summary>
        /// Фамилия контакта.
        /// </summary>
        private string _surname;

        /// <summary>
        /// Возвращает и задаёт номер контакта, должен состоять из 11 цифр.
        /// </summary>
        public int Number
        {
            get
            {
                return _number;
            }
            set
            {
                if(value.ToString().Length != 11)
                {
                    throw new ArgumentException("Неверный формат номера телефона");
                }

                _number = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт имя контакта, должно состоять из латиницы.
        /// </summary>
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _name = value;
            }
        }


        /// <summary>
        /// Возвращает и задаёт фамилию контакта, должна состоять из латиницы.
        /// </summary>
        public string Surname
        {
            get
            {
                return _surname;
            }
            set
            {
                AssertStringContainsOnlyLetters(value);
                _surname = value;
            }
        }

        /// <summary>
        /// Метод, который проверяет, состоит ли строка только из латиницы.
        /// </summary>
        /// <param name="name">Строка, которую нужно проверить.</param>
        private void AssertStringContainsOnlyLetters(string name)
        {
            foreach (char c in name)
            {
                if (!(((c >= 'a') && (c <= 'z')) || ((c >= 'A') && (c <= 'Z'))))
                {
                    throw new ArgumentException("Допустимы только символы английского алфавита");
                }
            }
        }

        /// <summary>
        /// Создает пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }
        
        /// <summary>
        /// Создает экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя контакта. Должно состоять только из латиницы.</param>
        /// <param name="surname">Фамилия контакта. Должна состоять только из латиницы.</param>
        /// <param name="number">Номер контакта. Должен содержать 11 цифр.</param>
        public Contact(string name, string surname, int number)
        {
            this.Name = name;
            this.Surname = surname;
            this.Number = number;
        }
    }
}
