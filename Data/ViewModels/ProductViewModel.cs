using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using WPFSmetaninProject.Data.Context;
using WPFSmetaninProject.Data.Core;
using WPFSmetaninProject.Data.Models;

namespace WPFSmetaninProject.Data.ViewModels
{
    class ProductViewModel : INotifyPropertyChanged
    {

        private string txtsearch;
        public string TxtSearch
        {
            get { return txtsearch; }
            set
            {
                txtsearch = value;
                OnPropertyChanged();
                Products = ConnectToDb.db.Products.Where(pr => pr.Title.ToLower().StartsWith(TxtSearch.ToLower()) || pr.Description.ToLower().StartsWith(TxtSearch.ToLower())).ToList();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {

            PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        private List<Product> products = ConnectToDb.db.Products.ToList();
        public List<Product> Products
        {
            get { return products; }
            private set
            {
                products = value; OnPropertyChanged();
            }
        }

        public RelayCommand ChangeProduct => new RelayCommand(obj => { });
    }
}
