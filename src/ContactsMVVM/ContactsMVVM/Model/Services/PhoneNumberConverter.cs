using System.Text.RegularExpressions;

namespace ContactsMVVM.Model.Services
{
    /// <summary>
    /// Конвертация номера телефона.
    /// </summary>
    public class PhoneNumberConverter
    {
        /// <summary>
        /// Преобразует номер телефона по типу:  +7 (XXX) XXX-XX-XX.
        /// </summary>
        /// <param name="phoneNumber">Строка с исходным номером телефона.</param>
        /// <returns>Номер телефона: +7 (XXX) XXX-XX-XX.</returns>
        public static string ConvertToNumber(string phoneNumber)
        {
            if (string.IsNullOrEmpty(phoneNumber))
                return string.Empty;

            phoneNumber = Regex.Replace(phoneNumber, @"[^\d]", "");

            if (phoneNumber.Length > 0 && phoneNumber[0] != '7')
            {
                phoneNumber = "7" + phoneNumber;
            }

            if (phoneNumber.Length > 11)
                phoneNumber = phoneNumber.Substring(0, 11);

            phoneNumber = Regex.Replace(phoneNumber, @"(\d{1})(\d{3})(\d{0,3})(\d{0,2})(\d{0,2})", match =>
            {
                string countryCode = match.Groups[1].Value;
                string regionCode = match.Groups[2].Value;
                string prefix = match.Groups[3].Value;
                string middlePart = match.Groups[4].Value;
                string endPart = match.Groups[5].Value;

                string formattedNumber = $"+{countryCode} ({regionCode}) {prefix}";

                if (middlePart.Length > 0)
                {
                    formattedNumber += $"-{middlePart}";
                }

                if (endPart.Length > 0)
                {
                    formattedNumber += $"-{endPart}";
                }

                return formattedNumber;
            });
            return phoneNumber;
        }
    }
}