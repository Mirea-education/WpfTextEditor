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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApplication.ClassData;

namespace WpfApplication.PagesAppls
{
    /// <summary>
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void BtnConnect_Click(object sender, RoutedEventArgs e)
        {
            if (TxbLogin.Text == "test" && PsbPassword.Password == "test")
            {
                MessageBox.Show(new ClassLibraryPrOne.ActionText().InsertText("Петя"));
                ClassFrameNavigation.frmBodyNav.Navigate(new PageAccount());
            }
            else {
                MessageBox.Show("Данный пользователь отсутствует.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
