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
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для AdminProductWindow.xaml
    /// </summary>
    public partial class AdminProductWindow : Window
    {
        public AdminProductWindow(User user)
        {
            InitializeComponent();
            Demo29Entities db = new Demo29Entities();
            ProductDG.ItemsSource = db.Product.ToList();
            FIOLb.Content = user.UserSurname + " " + user.UserName + " " + user.UserPatronymic;
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wind = new MainWindow();
            wind.Show();
            this.Close();
        }
    }
}
