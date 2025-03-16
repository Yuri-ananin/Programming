using System.ComponentModel.DataAnnotations;

namespace Contacts.ViewModel.Services.ValidationAttributes
{
    /// <summary>
    /// Атрибут валидации имени контакта.
    /// </summary>
    internal class ContactNameValidationAttribute : ValidationAttribute
    {
        /// <summary>
        /// Проверка на валидацию.
        /// </summary>
        /// <param name="value">Значение имени.</param>
        /// <returns>True - верное имя. False - неверное имя.</returns>
        public override bool IsValid(object value)
        {
            string name = value as string;
            if (string.IsNullOrWhiteSpace(name))
                return true;

            if (!ValueValidator.ValidateName(name))
            {
                ErrorMessage = "Имя может содержать русские и английские буквы";
                return false;
            }
            return true;
        }
    }
}