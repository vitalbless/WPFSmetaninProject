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
using WPFSmetaninProject.Pages;

namespace WPFSmetaninProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ApplicationContext db;
        public MainWindow()
        {
            InitializeComponent();
            db = new ApplicationContext();
            SuppObj.mainFrame = MainFrame;
            SuppObj.statusBarText = StatusOperation;
            SuppObj.mainFrame.Navigate(new PageMain());
        }

        private void btnFAQ_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            if (!SuppObj.mainFrame.CanGoBack)
            {
               SupplyMethods.SetMesssageToStatusBar( "Вы уже на главной странице");
            }
            else
            {
                SuppObj.mainFrame.GoBack();

            }
        }
    }
}
