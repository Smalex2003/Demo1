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
        public List<Product> thisproducts = new List<Product>();
        

        public ProductWindow(User user)
        {
            InitializeComponent();
            Demo29Entities db = new Demo29Entities();
            ProductDG.ItemsSource = db.Product.ToList();
            FIOLb.Content = user.UserSurname + " " + user.UserName + " " + user.UserPatronymic;
            thisproducts = db.Product.ToList();
            

        }


        private void AutorizationBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow wind = new MainWindow();
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
                products = products.Where(prod => prod.ProductDiscountAmount >= 10 && prod.ProductDiscountAmount < 15).ToList();
            }
            if (SelectCmb.SelectedIndex == 3)
            {
                products = products.Where(prod => prod.ProductDiscountAmount >= 15).ToList();
            }
            thisproducts = products;
            ProductDG.ItemsSource = thisproducts;


        }
        private void SearchTb_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SearchTb_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            Demo29Entities db = new Demo29Entities();
            int check = 0;
            List<Product> thisproducts1 = new List<Product>();
            foreach (Product pr in thisproducts)
            {
                for (int i = 0; i < SearchTb.Text.Length; i++)
                {
                    if (pr.ProductName[i] == SearchTb.Text[i])
                    {
                        check++;
                        
                    }
                }
                if (check == SearchTb.Text.Length)
                {
                    
                    thisproducts1.Add(pr);
                    
                }
                check = 0;

            }
            ProductDG.ItemsSource = thisproducts1;
        }
    }
}
