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
using WPFSmetaninProject.Data.Context;

namespace WPFSmetaninProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageProduct.xaml
    /// </summary>
    public partial class PageProduct : Page
    {
        ApplicationContext db;
        public PageProduct()
        {
            InitializeComponent();
            db= new ApplicationContext();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSaleHistory_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            lBoxProduct.ItemsSource = db.Products.ToList();
        }
    }
}
