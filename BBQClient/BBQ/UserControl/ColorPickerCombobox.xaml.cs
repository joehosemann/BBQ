using System.Windows;
using System.Windows.Media;

namespace BBQ.UserControl
{
    /// <summary>
    /// Interaction logic for ColorPickerCombobox.xaml
    /// </summary>
    public partial class ColorPickerCombobox
    {
        public ColorPickerCombobox()
        {
            InitializeComponent();
        }


        public Brush SelectedColor
        {
            get { return (Brush)GetValue(SelectedColorProperty); }
            set { SetValue(SelectedColorProperty, value); }
        }

        // Using a DependencyProperty as the backing store for SelectedColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SelectedColorProperty =
            DependencyProperty.Register("SelectedColor", typeof(Brush), typeof(ColorPickerCombobox), new UIPropertyMetadata(null));


    }
}

