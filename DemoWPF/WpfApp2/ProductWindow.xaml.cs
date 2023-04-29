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
    /// Логика взаимодействия для ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        
        public ProductWindow(User user)
        {
            InitializeComponent();
            Demo29Entities db = new Demo29Entities();
            ProductDG.ItemsSource = db.Product.ToList();
            FIOLb.Content = user.UserSurname + " " + user.UserName + " " + user.UserPatronymic;
           
        }

        private void AutorizationBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wind=new MainWindow();
            wind.Show();
            this.Close();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Demo29Entities db = new Demo29Entities();
            List<Product> products = db.Product.ToList();
            
            if (SelectCmb.SelectedIndex == 1)
            {
                products = products.Where(prod => prod.ProductDiscountAmount < 10).ToList();
            }
            if (SelectCmb.SelectedIndex == 2)
            {
                products = products.Where(prod => prod.ProductDiscountAmount >= 10&& prod.ProductDiscountAmount<15).ToList();
            }
            if (SelectCmb.SelectedIndex == 3)
            {
                products = products.Where(prod => prod.ProductDiscountAmount >= 15 ).ToList();
            }
            ProductDG.ItemsSource=products;


        }
    }
}
