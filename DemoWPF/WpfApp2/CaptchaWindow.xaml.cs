﻿using System;
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
    /// Логика взаимодействия для CaptchaWindow.xaml
    /// </summary>
    public partial class CaptchaWindow : Window
    {
        public CaptchaWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Функция проверки введенных значений капчи
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ClickCaptchaCheck(object sender, RoutedEventArgs e)
        {
            if(TextBoxNumbers.Text == MainWindow.CaptchaNumbers.ToString())
            {
                MessageBox.Show("Символы введены верно");
                MainWindow.NumbersOfIncorrectAuthorizations = 0;
                MainWindow.captchaWindow.Hide();
            }
            else
            {
                MessageBox.Show("Символы введены неверно!");
            }
        }
    }
}
