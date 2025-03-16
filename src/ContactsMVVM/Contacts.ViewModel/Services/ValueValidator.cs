using System.Text.RegularExpressions;

namespace Contacts.ViewModel.Services
{
    /// <summary>
    /// Методы для проверки значений.
    /// </summary>
    internal static class ValueValidator
    {
        /// <summary>
        /// Метод проверки на правильность ввода номера.
        /// </summary>
        /// <param name="number">Номер телефона.</param>
        /// <returns>True - верно введён. False - неправильно введён.</returns>
        public static bool ValidatePhoneNumber(string number)
        {
            if (!string.IsNullOrWhiteSpace(number))
            {
                return Regex.IsMatch(number, @"^\+7 \(\d{3}\) \d{3}-\d{2}-\d{2}$");
            }
            return true;
        }

        /// <summary>
        /// Метод проверки на правильность ввода имени контакта.
        /// </summary>
        /// <param name="name">Имя для проверки.</param>
        /// <returns>True - верно введено. False - неправильно введено.</returns>
        public static bool ValidateName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                string pattern = @"^[a-zA-Zа-яА-Я\s]+$";
                Regex regex = new Regex(pattern);
                return (regex.IsMatch(name) && name.Length <= 100);
            }
            return true;
        }

        /// <summary>
        /// Метод проверки на правильность ввода почты.
        /// </summary>
        /// <param name="email">Почта для проверки.</param>
        /// <returns>True - верно введена. False - неправильно введена</returns>
        public static bool ValidateEmail(string email)
        {
            if (!string.IsNullOrWhiteSpace(email))
            {
                string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
                Regex regex = new Regex(pattern);
                return (regex.IsMatch(email) && email.Length <= 100);
            }
            return true;
        }
    }
}