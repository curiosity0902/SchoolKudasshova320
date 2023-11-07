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
        public static List<Worker> workers { get; set; }
        public static List<Discipline> disciplines { get; set; }
        public static List<Faculty> faculties { get; set; }

        public static Worker loggedUser;
        public static Chair chair1 = new Chair();
        public ChairPage()
        {
            InitializeComponent();
            faculties = new List<Faculty>(DBConnection.practise320_KudashovaAnnaEntities.Faculty.ToList());
            disciplines = new List<Discipline>(DBConnection.practise320_KudashovaAnnaEntities.Discipline.ToList());
            workers = new List<Worker>(DBConnection.practise320_KudashovaAnnaEntities.Worker.ToList());
            chairs = DBConnection.practise320_KudashovaAnnaEntities.Chair.Where(x => x.ID == DBConnection.loginedUser.ID_Chair).ToList();

            loggedUser = DBConnection.loginedUser;
 
            this.DataContext = this;
        }

        private void ExitBT_Click_1(object sender, RoutedEventArgs e)
        {
        NavigationService.GoBack();
        }


        public void Refresh()
        {
            ChairLv.ItemsSource = chairs;
        }

        private void ChairLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ChairLv.SelectedItem is Chair chair)
            {
                ChairLv.SelectedItem = null;
                NavigationService.Navigate(new AddDepartmentPage(chair));
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Refresh();
        }
    }
}
