namespace Contacts.Model
{
    /// <summary>
    /// Хранит контактные данные телефона.
    /// </summary>
    public class Contact
    {
        /// <summary>
        /// Возвращает и задает имя контакта. Может содержать русские и английские буквы.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Возвращает и задает номер контакта. Должен быть Российский код номера.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Возвращает и задаёт почту контакта. Должен соответствовать формату почты.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Contact"/>.
        /// </summary>
        /// <param name="name">Имя. Должно содержать русские и английские буквы.</param>
        /// <param name="number">Номер телефона контакта по типу +7XXXXXXXXXX.</param>
        /// <param name="email">Адрес электронной почты. Должен соответствовать формату.</param>
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
    }
}