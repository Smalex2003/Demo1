using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Data.SqlTypes;
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
    /// Логика взаимодействия для ChangeProductWindow.xaml
    /// </summary>
    public partial class ChangeProductWindow : Window
    {
        string photopath;
        public static Product currentProduct;
        public ChangeProductWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Функция выбора фото
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChoosePhotoClick(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
            {
                photopath = dialog.FileName;
                MessageBox.Show("Фото выбрано");
            }
        }

        /// <summary>
        /// Функция изменения данных продукта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeProductClick(object sender, RoutedEventArgs e)
        {
            try
            {
                currentProduct.ProductManufacturer = ManufacturerComboBox.SelectedItem as ProductManufacturer;
                currentProduct.ProductName = NameTextBox.Text;
                currentProduct.ProductSupplier = SupplierComboBox.SelectedItem as ProductSupplier;
                currentProduct.ProductCategory = CategoryComboBox.SelectedItem as ProductCategory;
                currentProduct.ProductCost = decimal.Parse(PriceTextBox.Text);
                currentProduct.ProductDescription = DescriptionTextBox.Text;
                currentProduct.ProductMaxDiscountAmount = byte.Parse(MaxDiscountTextBox.Text);
                currentProduct.ProductDiscountAmount = byte.Parse(DiscountTextBox.Text);
                currentProduct.ProductQuantityInStock = int.Parse(QuantityTextBox.Text);
                if (photopath != null)
                {
                    currentProduct.ProductPhoto = photopath;
                    currentProduct.ProductPhoto = photopath;
                }

                MainWindow.db.SaveChanges();
                MessageBox.Show("Вы успешно отредактировали товар!");
                this.Hide();
                MainWindow.adminWindow.AdminProductGrid.ItemsSource = MainWindow.db.Product.ToList();
            }
            catch
            {
                MessageBox.Show("Вы неверно заполнили поля");
            }
        }

        /// <summary>
        /// Функция закрытия окна
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Close(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        /// <summary>
        /// Функция кнопки для удаления продукта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteProductClick(object sender, RoutedEventArgs e)
        {
            MainWindow.db.Product.Remove(currentProduct);
            MainWindow.db.SaveChanges();
            MessageBox.Show("Вы успешно удалили продукт");
            this.Hide();
            MainWindow.adminWindow.AdminProductGrid.ItemsSource = MainWindow.db.Product.ToList();
        }
    }
}
