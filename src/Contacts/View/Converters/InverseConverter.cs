using System;
using System.Globalization;
using System.Reflection.Metadata.Ecma335;
using System.Windows;
using System.Windows.Data;

namespace View.Converters
{
    public class InverseConverter : IValueConverter
    {
        /// <summary>
        /// Конвертирует булевое значение в противоположное.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="targetType">Целевой тип.</param>
        /// <param name="parameter">Параметр.</param>
        /// <param name="culture">Региональная культура</param>
        /// <returns>Значение видимости элемента.</returns>
        public object Convert(object value,
                              Type targetType,
                              object parameter,
                              CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                return !boolValue;
            }

            throw new ArgumentException("Value must be bool.");
        }

        /// <summary>
        /// Конвертирует булевое значение в противоположное.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="targetType">Целевой тип.</param>
        /// <param name="parameter">Параметр.</param>
        /// <param name="culture">Региональная культура</param>
        /// <returns>Булевое значение.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool boolValue)
            {
                return !boolValue;
            }

            throw new ArgumentException("Value must be bool.");
        }
    }
}