using System;
using System.Collections.Generic;
using System.Data.Common;
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
using SchoolKudasshova320.DB;
using SchoolKudasshova320.Pages;

namespace SchoolKudasshova320.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddChairPage.xaml
    /// </summary>
    public partial class AddChairPage : Page
    {
        public static List<Chair> chairs { get; set; }
        public static List<Worker> workers { get; set; }
        public static List<Faculty> faculties { get; set; }

        public static Worker loggedUser;
        public static Chair chair1 = new Chair();
        public AddChairPage()
        {
            InitializeComponent();
            loggedUser = DBConnection.loginedUser;

            faculties = new List<Faculty>(DBConnection.practise320_KudashovaAnnaEntities.Faculty.ToList());
            workers = new List<Worker>(DBConnection.practise320_KudashovaAnnaEntities.Worker.ToList());
            chairs = DBConnection.practise320_KudashovaAnnaEntities.Chair.Where(x => x.ID == DBConnection.loginedUser.ID_Chair).ToList();
            this.DataContext = this;
            //FacultyCB.ItemsSource = DbConnection.practise320_KudashovaAnnaEntities.Faculty.ToList();
        }

        private void SaveChageBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

