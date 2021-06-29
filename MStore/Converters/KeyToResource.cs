using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Manage.Converters
{
    public class KeyToResource : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var Key = (string)value;

            return Application.Current.Resources[Key];
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
