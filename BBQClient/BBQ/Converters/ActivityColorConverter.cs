using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace BBQ.Converters
{
    [ValueConversion(typeof(object), typeof(string))]
    public class ActivityColorConverter : IValueConverter
    {
        private int secondsTillExtended { get { return Properties.Settings.Default.SecondsTillExtended; } }


        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double val = TimeSpan.Parse((string)value).TotalSeconds;
            SolidColorBrush returnBrush = null;
            
            if (val == 0) // no calls holding
            {
                switch ((string)parameter)
                {
                    case "QueueBG":
                        return Properties.Settings.Default.InactiveCallTypeBG;
                    case "QueueFG":
                        return Properties.Settings.Default.InactiveQueueFG;
                    case "CallTypeBG":
                        return Properties.Settings.Default.InactiveCallTypeBG;
                    case "CallTypeFG":
                        return Properties.Settings.Default.InactiveCallTypeFG;
                }
            }
            else if (val <= secondsTillExtended) // call holding for 45 seconds or less
            {
                switch ((string)parameter)
                {
                    case "QueueBG":
                        return Properties.Settings.Default.ActiveQueueBG;
                    case "QueueFG":
                        return Properties.Settings.Default.ActiveQueueFG;
                    case "CallTypeBG":
                        return Properties.Settings.Default.ActiveCallTypeBG;
                    case "CallTypeFG":
                        return Properties.Settings.Default.ActiveCallTypeFG;
                }
            }
            else // call holding longer than 45 seconds
                switch ((string)parameter)
                {
                    case "QueueBG":
                        return Properties.Settings.Default.ExtendedQueueBG;
                    case "QueueFG":
                        return Properties.Settings.Default.ExtendedQueueFG;
                    case "CallTypeBG":
                        return Properties.Settings.Default.ExtendedCallTypeBG;
                    case "CallTypeFG":
                        return Properties.Settings.Default.ExtendedCallTypeFG;
                }
            return returnBrush;
        }

        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            throw new Exception("Cant convert back");
        }
    }
}
