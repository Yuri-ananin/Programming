using System;

namespace ContactsMVVM.Model
{
    /// <summary>
    /// Хранит контактные данные телефона.
    /// </summary>
    internal class Contact : ICloneable
    {

        /// <summary>
        /// Возвращает и задает имя контакта.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает номер контакта.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Возвращает и задаёт почту контакта.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="number">Номер телефона.</param>
        /// <param name="email">Адрес электронной почты.</param>
        public Contact(string name, string number, string email)
        {
            Name = name;
            PhoneNumber = number;
            Email = email;
        }

        /// <summary>
        /// Создаёт пустой экземпляр класса <see cref="Contact"/>.
        /// </summary>
        public Contact()
        {

        }

        /// <summary>
        /// Создаёт копию контакта.
        /// </summary>
        /// <returns>Копия контакта.</returns>
        public object Clone()
        {
            return new Contact(string.Copy(Name), string.Copy(PhoneNumber), string.Copy(Email));
        }
    }
}