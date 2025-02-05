using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model
{
    /// <summary>
    /// Описывает данные контакта.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Задаёт и возвращает имя контакта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Задаёт и возвращает номер телефона контакта.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Задаёт и возвращает электронную почту контакта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="phone">Номер телефона контакта.</param>
        /// <param name="email">Электронная почта контакта.</param>
        public Contact(string name, string phone, string email)
        {
            Name = name;
            Phone = phone;
            Email = email;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }
    }
}
