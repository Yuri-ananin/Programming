using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace ContactsMVVM.Model.Services
{
    /// <summary>
    /// Конвертация <see cref="Visibility"/> значений.
    /// </summary>
    class VisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Конвертер Visibility значений.
        /// </summary>
        /// <param name="value">Значение типа <see cref="bool"/>.</param>
        /// <param name="targetType">Ожидаемый тип.</param>
        /// <param name="parameter">Парамтер.</param>
        /// <param name="culture"><see cref="CultureInfo>"./></param>
        /// <returns>Visibility - True, Collapsed - False</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                return boolValue ? Visibility.Visible : Visibility.Collapsed;
            }
            return Visibility.Collapsed;
        }

        /// <summary>
        /// Обратная конвертация Visibility.
        /// </summary>
        /// <param name="value">Значение типа <see cref="bool"/>.</param>
        /// <param name="targetType">Тип.</param>
        /// <param name="parameter">Парамтер.</param>
        /// <param name="culture"><see cref="CultureInfo>"./></param>
        /// <returns></returns>
        /// <exception cref="NotSupportedException"></exception>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}