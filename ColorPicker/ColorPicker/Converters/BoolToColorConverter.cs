using System;
using System.Globalization;
using Xamarin.Forms;

namespace ColorPicker.Converters
{
    public class BoolToColorConverter: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var x = (bool)value;
            if (x) return Color.Tomato;
            else return Color.FromHex("#eee");
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
