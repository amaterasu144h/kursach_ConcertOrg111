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

namespace kursach_ConcertOrg111
{
    /// <summary>
    /// Логика взаимодействия для BuyTicket.xaml
    /// </summary>
    public partial class BuyTicket : Page
   
    {
        public Model.DB Connection { get; set; } = new Model.DB();
        public Model.GenresOfMusic GenresOfMusic { get; set; } = new Model.GenresOfMusic() { };
        public Model.Executor Executor { get; set; } = new Model.Executor();
        public Model.Place Place { get; set; } = new Model.Place();
        public Model.Price Price { get; set; } = new Model.Price();

     
        
        public BuyTicket()
        {
            InitializeComponent();
            ComboBoxGenresOfMusic.ItemsSource = Connection.GenresOfMusic.ToList();
            ComboBoxPlace.ItemsSource = Connection.Place.ToList();
            ComboBoxPrice.ItemsSource = Connection.Price.ToList();
        }
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxExecutor.ItemsSource = Connection.Executor.Where(ex => ex.Genres == GenresOfMusic.Genres).ToList();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Model.Receipt());

        }
    }
}
