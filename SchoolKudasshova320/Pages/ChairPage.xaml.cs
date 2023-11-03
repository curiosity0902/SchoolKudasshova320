using SchoolKudasshova320.DB;
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

namespace SchoolKudasshova320.Pages
{
    /// <summary>
    /// Логика взаимодействия для ChairPage.xaml
    /// </summary>
    public partial class ChairPage : Page
    {
        public static List<Chair> chairs { get; set; }

        public ChairPage()
        {
            InitializeComponent();
            chairs = new List<Chair>(DBConnection.practise320_KudashovaAnnaEntities.Chair.ToList());
            this.DataContext = this;
            ChairLv.ItemsSource = new List<Chair>(DBConnection.practise320_KudashovaAnnaEntities.Chair.ToList());
        }

        private void ExitBT_Click_1(object sender, RoutedEventArgs e)
        {
        NavigationService.GoBack();
        }

        private void ChairLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
