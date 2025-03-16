using System.ComponentModel.DataAnnotations;

namespace Contacts.ViewModel.Services.ValidationAttributes
{
    /// <summary>
    /// Атрибут валидации номера контакта.
    /// </summary>
    internal class ContactPhoneNumberValidationAttribute : ValidationAttribute
    {
        /// <summary>
        /// Проверка на валидацию.
        /// </summary>
        /// <param name="value">Значение номера.</param>
        /// <returns>True - верный номер. False - неверный номер.</returns>
        public override bool IsValid(object value)
        {
            string number = value as string;
            if (string.IsNullOrWhiteSpace(number))
                return true;

            if (!ValueValidator.ValidatePhoneNumber(number))
            {
                ErrorMessage = "Должен быть Российский код номера";
                return false;
            }
            return true;
        }
    }
}