using ContactsMVVM.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ContactsMVVM.ViewModel
{
    /// <summary>
    /// ViewModel для работы с контактом <see cref="Contact"/>. <see cref="INotifyPropertyChanged"/>.
    /// </summary>
    class ContactVM
    {
        /// <summary>
        /// Событие, для отслеживаня изменений в свойствах.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Экземпляр класса <see cref="Contact"/>.
        /// </summary>
        private Contact _contact;

        /// <summary>
        /// Возвращает и задаёт имя контакта.
        /// </summary>
        public string Name
        {
            get
            {
                return _contact.Name;
            }
            set
            {
                _contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Вовзращает и задаёт номер контакта.
        /// </summary>
        public string PhoneNumber
        {
            get
            {
                return _contact.PhoneNumber;
            }
            set
            {
                _contact.PhoneNumber = value;
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес электронной почты.
        /// </summary>
        public string Email
        {
            get
            {
                return _contact.Email;
            }
            set
            {
                _contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/>
        /// </summary>
        /// <param name="property">Название изменённого свойства.</param>
        private void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        /// <summary>
        /// Создаёт копию представления контакта.
        /// </summary>
        /// <returns>Копия <see cref="ContactVM"/></returns>
        public object Clone()
        {
            ContactVM returnContact = new ContactVM();
            returnContact._contact = (Contact)_contact.Clone();
            return returnContact;
        }

        /// <summary>
        /// Создаёт экземпляр класса Contact.
        /// </summary>
        public ContactVM()
        {
            _contact = new Contact();
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="name">Имя контакта.</param>
        /// <param name="number">Номер телефона контакта.</param>
        /// <param name="email">Адрес электронной почты.</param>
        public ContactVM(string name, string number, string email)
        {
            _contact = new Contact();
            _contact.Name = name;
            _contact.PhoneNumber = number;
            _contact.Email = email;
            Name = name;
            PhoneNumber = number;
            Email = email;
            OnPropertyChanged();
        }
    }
}