using Microsoft.Data.SqlClient;
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
using WPFSmetaninProject.Data;
using WPFSmetaninProject.Data.Context;
using WPFSmetaninProject.Data.Models;

namespace WPFSmetaninProject.Pages
{
    /// <summary>
    /// Логика взаимодействия для PaigAddProduct.xaml
    /// </summary>
    public partial class PaigAddProduct : Page

    {
        ApplicationContext db;
        public PaigAddProduct()
        {
            db = new ApplicationContext();
            InitializeComponent();
            cmbxProductManufacturer.SelectedValuePath = "Id";
            cmbxProductManufacturer.DisplayMemberPath = "Name";
            cmbxProductManufacturer.ItemsSource = db.Manufacturers.ToList();
            
        }        

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                db.Products.Add(new Product(txtbTitle.Text, Convert.ToInt32(txtbCost.Text), txtbDescription.Text, txtbImagePath.Text, 
                RbIsActive.IsChecked == true, Convert.ToInt32(cmbxProductManufacturer.SelectedValue)));
                db.SaveChanges();
                txtbTitle.Text = string.Empty;
                txtbCost.Text = string.Empty;
                txtbDescription.Text = string.Empty;
                cmbxProductManufacturer.SelectedIndex = default;
                txtbImagePath.Text = string.Empty;
                SupplyMethods.SetMesssageToStatusBar("Данные успешно добавлены");
            }
            catch(Exception ex)
            {
                SupplyMethods.SetMesssageToStatusBar($"Ошибка добавления данных. {ex.Message}");
            }
        }   
    }
}
