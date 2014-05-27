using System;
using System.Windows.Data;
using System.Windows.Media;

namespace BBQ.Converters
{
    public class BrushToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var brush = value as SolidColorBrush;
            if (brush != null) return brush.Color;
            return Colors.Transparent;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var color = (Color)value;
            return new SolidColorBrush(color);
        }
    }
}
