using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Configuration;
using System.Data;

namespace Lab8Try
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SqlConnection thisConnection = null;
        SqlCommand command = null;
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // определяем строку подключения
                thisConnection =
                new SqlConnection(
                ConfigurationManager.
                ConnectionStrings["myConnect"].
                ConnectionString);
                //открыть соединение
                thisConnection.Open();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            command = new SqlCommand("SELECT * FROM wasd", thisConnection);
            adapter = new SqlDataAdapter(command);
            ds = new DataSet();
            adapter.Fill(ds,"wasd");
            Dgreed.ItemsSource = ds.Tables["wasd"].DefaultView;

        }
    }
}
