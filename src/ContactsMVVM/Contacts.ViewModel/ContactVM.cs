using CommunityToolkit.Mvvm.ComponentModel;
using Contacts.Model;
using Contacts.ViewModel.Services;
using Contacts.ViewModel.Services.ValidationAttributes;

namespace Contacts.ViewModel
{
    /// <summary>
    /// ViewModel для работы с контактом <see cref="Contact"/>.
    /// </summary>
    public partial class ContactVM : ObservableValidator
    {
        /// <summary>
        /// Экземпляр класса <see cref="Contact"/>.
        /// </summary>
        private Contact _contact;

        [ObservableProperty]
        [ContactNameValidationAttribute]
        [NotifyDataErrorInfo]
        private string _name;

        [ObservableProperty]
        [ContactPhoneNumberValidationAttribute]
        [NotifyDataErrorInfo]
        private string _phoneNumber;

        [ObservableProperty]
        [ContactEmailValidationAttribute]
        [NotifyDataErrorInfo]
        private string _email;

        /// <summary>
        /// Конвертаци¤ номера в +7 (XXX) XXX-XX-XX.
        /// </summary>
        /// <param name="value">«Значение номера.</param>
        partial void OnPhoneNumberChanged(string value)
        {
            PhoneNumber = PhoneNumberConverter.ConvertToNumber(value);
        }

        /// <summary>
        /// Создает экземпляр класса Contact.
        /// </summary>
        public ContactVM()
        {
            _contact = new Contact();
        }

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactVM"/>.
        /// </summary>
        /// <param name="name">»Имя. Должно содержать русские и английские буквы.</param>
        /// <param name="number">Номер телефона контакта по типу +7XXXXXXXXXX.</param>
        /// <param name="email">Адрес электронной почты. Должен соответствовать формату.</param>
        public ContactVM(string name, string number, string email)
        {
            _contact = new Contact();
            Name = name;
            PhoneNumber = number;
            Email = email;
        }
    }
}