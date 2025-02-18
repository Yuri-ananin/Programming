using ContactsMVVM.Model.Services;
using ContactsMVVM.Model;
using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace ContactsMVVM.ViewModel
{
    /// <summary>
    /// ViewModel для работы с контактом <see cref="Contact"/>. <see cref="INotifyPropertyChanged"/>, <see cref="IDataErrorInfo"/>.
    /// </summary>
    internal class ContactVM : INotifyPropertyChanged, IDataErrorInfo, ICloneable
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
            get => _contact.Name;
            set
            {
                _contact.Name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        /// <summary>
        /// Вовзращает и задаёт номер контакта.
        /// </summary>
        /// <remarks>
        /// Преобразует номер телефона по типу: +7 (XXX) XXX-XX-XX.
        /// </remarks>
        public string PhoneNumber
        {
            get => _contact.PhoneNumber;
            set
            {

                _contact.PhoneNumber = PhoneNumberConverter.ConvertToNumber(value);
                OnPropertyChanged(nameof(PhoneNumber));
            }
        }

        /// <summary>
        /// Возвращает и задаёт адрес электронной почты.
        /// </summary>
        public string Email
        {
            get => _contact.Email;
            set
            {
                _contact.Email = value;
                OnPropertyChanged(nameof(Email));
            }
        }

        /// <summary>
        /// Проверка на правильность значений ViewModel. Реализация <see cref="IDataErrorInfo"/>.
        /// </summary>
        /// <param name="columnName">Название поля.</param>
        /// <returns>Строку с ошибкой.</returns>
        public string this[string columnName]
        {
            get
            {
                string error = GetErrorByName(columnName);
                return error;
            }
        }

        /// <summary>
        /// Возвращает ошибку в зависимости от свойства.
        /// </summary>
        /// <param name="columnName">Название свойства вызвавшего ошибку.</param>
        /// <returns>Строка с описанием ошибки.</returns>
        private string GetErrorByName(string columnName)
        {
            string error = null;
            switch (columnName)
            {
                case nameof(Name):
                    if (!ValueValidator.ValidateContactName(Name))
                    {
                        error = "Имя должно содержать русские и/или английские буквы и не длинее 100 символов";
                    }
                    break;
                case nameof(PhoneNumber):
                    if (!ValueValidator.ValidateNumber(PhoneNumber))
                    {
                        error = "Номер телефона должен соответствовать Российскому формату";
                    }
                    break;
                case nameof(Email):
                    if (!ValueValidator.ValidateEmail(Email))
                    {
                        error = "Почта дожна соответствовать формату и не длинее 100 символов";
                    }
                    break;
            }

            return error;
        }

        /// <summary>
        /// Ошибка валидации данных. Реализация <see cref="IDataErrorInfo"/>.
        /// </summary>
        public string Error
        {
            get
            {
                StringBuilder errors = new StringBuilder();
                string nameError = GetErrorByName(nameof(Name));
                if (!string.IsNullOrEmpty(nameError))
                    errors.Append(nameError + "\n");

                string phoneNumberError = GetErrorByName(nameof(PhoneNumber));
                if (!string.IsNullOrEmpty(phoneNumberError))
                    errors.Append(phoneNumberError + "\n");

                string emailError = GetErrorByName(nameof(Email));
                if (!string.IsNullOrEmpty(emailError))
                    errors.Append(emailError + "\n. ");

                return errors.ToString().TrimEnd('\n');
            }
        }

        /// <summary>
        /// Возвращает наличие ошибки в полях.
        /// </summary>
        /// <returns>True - есть хоть 1 ошибка в полях. False - всё верно.</returns>
        public bool HasValidationErrors()
        {
            return string.IsNullOrEmpty(this[nameof(Name)]) &&
                   string.IsNullOrEmpty(this[nameof(PhoneNumber)]) &&
                   string.IsNullOrEmpty(this[nameof(Email)]);
        }

        /// <summary>
        /// Вызывает событие <see cref="PropertyChanged"/>.
        /// </summary>
        /// <param name="property">Название изменённого свойства.</param>
        private void OnPropertyChanged([CallerMemberName] string property = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        /// <summary>
        /// Создаёт копию представления контакта.
        /// </summary>
        /// <returns>Копия <see cref="ContactVM"/>.</returns>
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
            OnPropertyChanged();
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="name">Имя. Должно содержать русские и английские буквы.</param>
        /// <param name="number">Номер телефона контакта по типу +7XXXXXXXXXX.</param>
        /// <param name="Email">Адрес электронной почты. Должен соответствовать формату.</param>
        public ContactVM(string name, string number, string email)
        {
            _contact = new Contact();
            Name = name;
            PhoneNumber = number;
            Email = email;
            OnPropertyChanged();
        }
    }
}