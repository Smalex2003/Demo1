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

namespace WpfApp2
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

        private void AutorizationBtn_Click(object sender, RoutedEventArgs e)
        {
            Demo29Entities db = new Demo29Entities();
            
            foreach(User user1 in db.User)
            {
                if(user1.UserPassword==PassTb.Text && user1.UserLogin == LoginTb.Text)
                {
                   
                    MessageBox.Show("Вы успешно авторизовались!");
                    if (user1.RoleID == 2)
                    {
                        AdminProductWindow wind1 = new AdminProductWindow(user1);
                        wind1.Show();
                        this.Close();
                        return;
                    }
                    else
                    {
                        ProductWindow wind = new ProductWindow(user1);
                        wind.Show();
                        this.Close();
                        return;
                    }
                    
                }
               
            }
            MessageBox.Show("Неверные логин или пароль!");
        }

        private void AutorizationBtn_Copy_Click(object sender, RoutedEventArgs e)
        {
            User user = new User();
            user.UserName = "Гость";
            ProductWindow wind = new ProductWindow(user);
            wind.Show();

        }
    }
}
