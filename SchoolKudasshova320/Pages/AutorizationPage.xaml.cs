using SchoolKudasshova320.DB;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
    /// Логика взаимодействия для AutorizationPage.xaml
    /// </summary>
    public partial class AutorizationPage : Page
    {
        public static List<Worker> workers { get; set; }
        public AutorizationPage()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTB.Text.Trim();
            string password = PasswordTB.Password.Trim();

            workers = new List<Worker>(DBConnection.practise320_KudashovaAnnaEntities.Worker.ToList());
            var currentUser = workers.FirstOrDefault(i => i.Login == login && i.Password == password);
            DBConnection.loginedUser = currentUser;
            if (currentUser != null && currentUser.Position == "преподаватель")
                NavigationService.Navigate(new ExamPage());
            else if (currentUser != null && currentUser.Position == "зав. кафедрой")
                NavigationService.Navigate(new ChairPage());
            else if (currentUser != null && currentUser.Position == "инженер")
                NavigationService.Navigate(new EngenerPage());
            else
                MessageBox.Show("Введите корректно!");
        }

        private void GostBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DisaplineList());
        }
    }
}
