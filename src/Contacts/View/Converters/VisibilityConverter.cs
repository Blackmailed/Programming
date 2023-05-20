using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View.Converters
{
    /// <summary>
    ///  Представляет реализацию для конвертирования bool значений.
    /// </summary>
    public class VisibilityConverter : IValueConverter
    {
        /// <summary>
        /// Конвертирует булевое значение в соответсвующее значение из перечисления.
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="targetType">Целевой тип</param>
        /// <param name="parameter">Параметр</param>
        /// <param name="culture">Региональное значение</param>
        /// <returns>Значение видимости элемента</returns>
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !bool.Parse(value.ToString() ?? bool.FalseString) ? Visibility.Visible : Visibility.Hidden;
        }

        /// <summary>
        /// Конвертирует соответсвующее значение в булевое значение.
        /// </summary>
        /// <param name="value">Значение</param>
        /// <param name="targetType">Целевой тип</param>
        /// <param name="parameter">Параметр</param>
        /// <param name="culture"></param>
        /// <returns>Булевое значение</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !Visibility.Visible.Equals(value);
        }
    }
}
