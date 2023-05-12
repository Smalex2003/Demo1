using System.IO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Win32;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static Demo29Entities db = new Demo29Entities();
        public static MainWindow mainWindow;
        public static ProductWindow productWindow = new ProductWindow();
        public static CaptchaWindow captchaWindow = new CaptchaWindow();
        public static AdminWindow adminWindow = new AdminWindow();
        public static ChangeProductWindow changeProductWindow = new ChangeProductWindow();
        public static AddProductWindow addProductWindow = new AddProductWindow();
        public static OrderWindow orderWindow = new OrderWindow();
        public static User CurrentUser;
        public static int NumbersOfIncorrectAuthorizations = 0;
        public static int CaptchaNumbers = 00000;
        public MainWindow()
        {
            InitializeComponent();
            mainWindow = this;
            PathInitialize();
        }
        /// <summary>
        /// Функция генерации капчи
        /// </summary>
        public void GenerateCaptcha()
        {
            Random rnd = new Random();
            CaptchaNumbers = rnd.Next(10000, 99999);
        }
        /// <summary>
        /// Функция инициализации пути для отображения фото
        /// </summary>
        public void PathInitialize()
        {
            string vivod = "";
            foreach (var Product in db.Product)
            {
               if (Product.ProductPhoto != null)
               {
                   if (Product.ProductPhoto.Contains("C:")){
                       Product.ProductPhoto =  Product.ProductPhoto;
                  }
                   else
                    {
                       Product.ProductPhoto = "Resources/" + Product.ProductPhoto;
                    }
                }
               vivod += Product.ProductPhoto + "\n";
           }
           
        }
        /// <summary>
        /// Функция копки закрытия
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExitClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        /// <summary>
        /// Функция открытия окна для администратора
        /// </summary>
        public void LoadAdminWindow()
        {
            this.Hide();
            adminWindow.AdminProductGrid.ItemsSource = db.Product.ToList();
            adminWindow.Show();
        }
        /// <summary>
        /// Функция нажатия кнопки авторизации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AuthorizationClick(object sender, RoutedEventArgs e)
        {
            if (NumbersOfIncorrectAuthorizations < 5)
            {
                User user = db.User.ToList()
                    .Where(us => us.UserLogin == LoginTextBox.Text && us.UserPassword == PasswordTextBox.Text)
                    .FirstOrDefault();
                if (user != null)
                {
                   // MessageBox.Show("Ваша роль: " + user.Role.RoleName);
                    if (user.Role.RoleName == "Администратор")
                    {
                        LoadAdminWindow();
                        CurrentUser = user;
                    }
                    else if(user.Role.RoleName == "Клиент")
                    {
                        productWindow.ProductListView.ItemsSource = db.Product.ToList();
                        mainWindow.Hide();
                        productWindow.Show();
                        productWindow.InfoTextBox.Text = "Количество: " + MainWindow.db.Product.ToList().Count + "/" + MainWindow.db.Product.ToList().Count;
                        productWindow.ChangeColorIfDiscountLargerThan15();
                    }
                }
                else
                {
                    MessageBox.Show("Неверные данные для входа");
                    NumbersOfIncorrectAuthorizations++;

                    TextBoxClear();
                    if (NumbersOfIncorrectAuthorizations >= 5)
                    {
                        captchaWindow.Show();
                        GenerateCaptcha();
                        captchaWindow.CaptchaTextBlock.Text = CaptchaNumbers.ToString();
                        MessageBox.Show("Вы потратили на авторизацию слишком много попыток");
                    }
                }
            }
            else
            {
                captchaWindow.Show();
                GenerateCaptcha();
                captchaWindow.CaptchaTextBlock.Text = CaptchaNumbers.ToString();
                MessageBox.Show("Сначала пройдите капчу!");
            }
        }

        /// <summary>
        /// Функция для отчистки текстовых полей
        /// </summary>
        public void TextBoxClear()
        {
            PasswordTextBox.Text = "";
            LoginTextBox.Text = "";
        }
        /// <summary>
        /// Функция загрузки продуктов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ProductsClick(object sender, RoutedEventArgs e)
        {
            productWindow.ProductListView.ItemsSource = db.Product.ToList();
            mainWindow.Hide();
            productWindow.Show();
            productWindow.InfoTextBox.Text = "Количество: " + MainWindow.db.Product.ToList().Count + "/" + MainWindow.db.Product.ToList().Count;
            productWindow.ChangeColorIfDiscountLargerThan15();
        }
    }
}
