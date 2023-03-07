using System;
using System.Collections.Generic;
using System.Linq;
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
using System.Drawing;
namespace Lab4_5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           Cursor customCursor = new Cursor(@"C:\Users\mdxbu\Labs\4SEMESTR\OOP4SEM\Lab4_5\Lab4_5\images\cursor2.cur");
            this.Cursor = customCursor;
            dPicker.DisplayDateStart = DateTime.Now;
            dPicker.SelectedDate = DateTime.Today;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(departure.Text.Length > 3)
            {
                if (destination.Text.Length > 3)
                {
                    Results r = new Results(departure.Text,destination.Text, Convert.ToDateTime(dPicker.Text));
                    r.Show();   
                }
                
            }
            
        }

        private void departure_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            foreach (char c in e.Text)
            {
                if (!Char.IsLetter(c))
                {
                    e.Handled = true;
                    break;
                }
            }
        }


        private void ENGlang_Click(object sender, RoutedEventArgs e)
        {
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri("Dictionary-en.xaml", UriKind.RelativeOrAbsolute);
            this.Resources.MergedDictionaries.Clear();
            this.Resources.MergedDictionaries.Add(dict);
        }
        private void RUlang_Click_1(object sender, RoutedEventArgs e)
        {
            ResourceDictionary dict = new ResourceDictionary();
            dict.Source = new Uri("Dictionary-ru.xaml", UriKind.RelativeOrAbsolute);
            this.Resources.MergedDictionaries.Clear();
            this.Resources.MergedDictionaries.Add(dict);

        }
    }
}
