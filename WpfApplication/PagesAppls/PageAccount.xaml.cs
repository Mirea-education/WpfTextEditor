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
    /// Логика взаимодействия для PageAccount.xaml
    /// </summary>
    public partial class PageAccount : Page
    {
        public PageAccount()
        {
            InitializeComponent();
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            ClassFrameNavigation.frmBodyNav.GoBack();
        }
    }
}
