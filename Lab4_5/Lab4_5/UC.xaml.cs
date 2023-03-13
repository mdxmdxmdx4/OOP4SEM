using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Lab4_5
{
    /// <summary>
    /// Логика взаимодействия для UC1.xaml
    /// </summary>
    public partial class UC : Button
    {
        public static readonly DependencyProperty CustomBackgroundProperty =
               DependencyProperty.Register("CustomBackground", typeof(Color), typeof(UC),
                   new FrameworkPropertyMetadata(Colors.Red,
                       FrameworkPropertyMetadataOptions.AffectsRender | FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                       new PropertyChangedCallback(OnCustomBackgroundChanged),
                       new CoerceValueCallback(CoerceCustomBackground),
                       true),
                   new ValidateValueCallback(IsValidColor));

        public Color CustomBackground
        {
            get { return (Color)GetValue(CustomBackgroundProperty); }
            set { SetValue(CustomBackgroundProperty, value); }
        }

        private static bool IsValidColor(object value)
        {
            return value is Color;
        }

        private static void OnCustomBackgroundChanged(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            UC button = (UC)obj;
            button.Background = new SolidColorBrush((Color)args.NewValue);
        }

        private static object CoerceCustomBackground(DependencyObject obj, object value)
        {
            if (value == null || !(value is Color))
            {
                return Colors.Red;
            }
            else
            {
                return value;
            }
        }

        public UC():base()
        {
            Click += MyButton_Click;
        }

        private void MyButton_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            byte[] colorBytes = new byte[3];
            random.NextBytes(colorBytes);
            Color newColor = Color.FromArgb(255, colorBytes[0], colorBytes[1], colorBytes[2]);
            CustomBackground = newColor;
        }


    }
}
