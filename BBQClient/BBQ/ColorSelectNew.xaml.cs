using System.Windows;
using System.Windows.Media;

namespace BBQ
{
    /// <summary>
    /// Interaction logic for ColorSelectNew.xaml
    /// </summary>
    public partial class ColorSelectNew : Window
    {
        public ColorSelectNew()
        {
            this.InitializeComponent();
            this.Loaded += new RoutedEventHandler(ColorSelectNew_Loaded);

            if (Properties.Settings.Default.InactiveApplicationBackground == null)
            {
                Properties.Settings.Default.InactiveApplicationBackground = new SolidColorBrush(Colors.LightGray);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.InactiveQueueBG == null)
            {
                Properties.Settings.Default.InactiveQueueBG = new SolidColorBrush(Colors.LightGray);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.InactiveQueueFG == null)
            {
                Properties.Settings.Default.InactiveQueueFG = new SolidColorBrush(Colors.Black);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.InactiveCallTypeBG == null)
            {
                Properties.Settings.Default.InactiveCallTypeBG = new SolidColorBrush(Colors.White);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.InactiveCallTypeFG == null)
            {
                Properties.Settings.Default.InactiveCallTypeFG = new SolidColorBrush(Colors.Black);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ActiveQueueBG == null)
            {
                Properties.Settings.Default.ActiveQueueBG = new SolidColorBrush(Colors.LightGray);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ActiveQueueFG == null)
            {
                Properties.Settings.Default.ActiveQueueFG = new SolidColorBrush(Colors.Black);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ActiveCallTypeBG == null)
            {
                Properties.Settings.Default.ActiveCallTypeBG = new SolidColorBrush(Colors.Pink);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ActiveCallTypeFG == null)
            {
                Properties.Settings.Default.ActiveCallTypeFG = new SolidColorBrush(Colors.Black);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ExtendedQueueBG == null)
            {
                Properties.Settings.Default.ExtendedQueueBG = new SolidColorBrush(Colors.LightGray);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ExtendedQueueFG == null)
            {
                Properties.Settings.Default.ExtendedQueueFG = new SolidColorBrush(Colors.Black);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ExtendedCallTypeBG == null)
            {
                Properties.Settings.Default.ExtendedCallTypeBG = new SolidColorBrush(Colors.Red);
                Properties.Settings.Default.Save();
            }
            if (Properties.Settings.Default.ExtendedCallTypeFG == null)
            {
                Properties.Settings.Default.ExtendedCallTypeFG = new SolidColorBrush(Colors.Black);
                Properties.Settings.Default.Save();
            }

            inactiveApplicationBackground.SelectedColor = Properties.Settings.Default.InactiveApplicationBackground.Color;
            inactiveQueueBG.SelectedColor = Properties.Settings.Default.InactiveQueueBG.Color;
            inactiveQueueFG.SelectedColor = Properties.Settings.Default.InactiveQueueFG.Color;
            inactiveCallTypeBG.SelectedColor = Properties.Settings.Default.InactiveCallTypeBG.Color;
            inactiveCallTypeFG.SelectedColor = Properties.Settings.Default.InactiveCallTypeFG.Color;
            // activeQueueBG.SelectedColor = Properties.Settings.Default.ActiveQueueBG.Color;
            // activeQueueFG.SelectedColor = Properties.Settings.Default.ActiveQueueFG.Color;
            activeCallTypeBG.SelectedColor = Properties.Settings.Default.ActiveCallTypeBG.Color;
            activeCallTypeFG.SelectedColor = Properties.Settings.Default.ActiveCallTypeFG.Color;
            extendedCallTypeBG.SelectedColor = Properties.Settings.Default.ExtendedCallTypeBG.Color;
            extendedCallTypeFG.SelectedColor = Properties.Settings.Default.ExtendedCallTypeFG.Color;

        }

        void ColorSelectNew_Loaded(object sender, RoutedEventArgs e)
        {


        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.InactiveApplicationBackground.Color = inactiveApplicationBackground.SelectedColor;
            Properties.Settings.Default.InactiveQueueBG.Color = inactiveQueueBG.SelectedColor;
            Properties.Settings.Default.InactiveQueueFG.Color = inactiveQueueFG.SelectedColor;
            Properties.Settings.Default.InactiveCallTypeBG.Color = inactiveCallTypeBG.SelectedColor;
            Properties.Settings.Default.InactiveCallTypeFG.Color = inactiveCallTypeFG.SelectedColor;
            Properties.Settings.Default.ActiveQueueBG.Color = activeQueueBG.SelectedColor;
            Properties.Settings.Default.ActiveQueueFG.Color = activeQueueFG.SelectedColor;
            Properties.Settings.Default.ActiveCallTypeBG.Color = activeCallTypeBG.SelectedColor;
            Properties.Settings.Default.ActiveCallTypeFG.Color = activeCallTypeFG.SelectedColor;
            Properties.Settings.Default.ExtendedCallTypeBG.Color = extendedCallTypeBG.SelectedColor;
            Properties.Settings.Default.ExtendedCallTypeFG.Color = extendedCallTypeFG.SelectedColor;
            Properties.Settings.Default.Save();

            this.Close();
        }


    }
}