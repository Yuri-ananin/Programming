using System.ComponentModel.DataAnnotations;

namespace Contacts.ViewModel.Services.ValidationAttributes
{
    /// <summary>
    /// Атрибут валидации почты контакта.
    /// </summary>
    internal class ContactEmailValidationAttribute : ValidationAttribute
    {
        /// <summary>
        /// Проверка на валидацию.
        /// </summary>
        /// <param name="value">Значение почты.</param>
        /// <returns>True - верная почта. False - неверная почта.</returns>
        public override bool IsValid(object value)
        {
            string email = value as string;
            if (string.IsNullOrWhiteSpace(email))
                return true;

            if (!ValueValidator.ValidateEmail(email))
            {
                ErrorMessage = "Должен соответствовать формату почты";
                return false;
            }
            return true;
        }
    }
}