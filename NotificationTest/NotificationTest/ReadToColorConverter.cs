using System;
using System.Globalization;
using Xamarin.Forms;

namespace NotificationTest
{
    public class ReadToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool)
            {
                return (bool)value
                    ? Color.Blue
                    : Color.Red;
            }
            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
