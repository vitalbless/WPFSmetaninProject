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
using WPFSmetaninProject.Data;

namespace WPFSmetaninProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void btnService_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnClient_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            SuppObj.mainFrame.Navigate(new PageProduct());
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            SuppObj.mainFrame.Navigate(new PaigAddProduct());
        }

        private void btnStuff_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCompany_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
