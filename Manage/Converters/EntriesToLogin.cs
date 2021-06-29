using System;
using System.Globalization;
using System.Windows.Data;

namespace Manage.Converters
{
    public class EntriersToLogin : IMultiValueConverter
    {
        object IMultiValueConverter.Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            var val = values.Clone();
            return val;
        }

        object[] IMultiValueConverter.ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
