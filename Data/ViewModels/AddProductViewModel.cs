using System;
using System.Collections.Generic;
using System.Linq;
using WPFSmetaninProject.Data.Context;
using WPFSmetaninProject.Data.Core;
using WPFSmetaninProject.Data.Models;

namespace WPFSmetaninProject.Data.ViewModels
{
    class AddProductViewModel

    {
        ApplicationContext db = new ApplicationContext();
        private string _title;

        public string Title
        {
            get => _title; set => _title = value;
        }
        private int _cost;

        public int Cost
        {
            get { return _cost; }
            set { _cost = value; }
        }
        private string _description;

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }
        private string _mainImagePath;

        public string MainImagePath
        {
            get { return _mainImagePath; }
            set { _mainImagePath = value; }
        }
        private bool _isActive = true;

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }
        private int _manufacturerId;

        public int ManufacturerId
        {
            get { return _manufacturerId; }
            set { _manufacturerId = value; }

        }

        

        public IEnumerable<Manufacturer> Manufacturers
        {
            get { return ConnectToDb.db.Manufacturers.ToList(); ; }
           
        }


        private RelayCommand addProduct;
        public RelayCommand AddProduct
        {
            get
            {
                return addProduct ??
                  (addProduct = new RelayCommand(async obj =>
                 
                  {
                      try
                      {
                          Product product = new Product
                          {
                              Title = this.Title,
                              Description = this.Description,
                              Cost = this.Cost,
                              MainImagePath = this.MainImagePath,
                              IsActive = this.IsActive,
                              ManufacturerId = this.ManufacturerId
                          };
                          if (product != null)
                          {
                              ConnectToDb.db.Products.Add(product);
                              ConnectToDb.db.SaveChanges();
                              SupplyMethods.SetMesssageToStatusBar($"Модель телефона {Title} успешно добавлена!");
                              this.Title = string.Empty;
                              this.Description = string.Empty;
                              this.Cost = 0;
                              this.MainImagePath = string.Empty;
                              this.ManufacturerId = -1;
                              this.IsActive = true;
                          }
                      }
                      catch(Exception ex)
                      {
                          SupplyMethods.SetMesssageToStatusBar($"Возникла ошибка при добавлении данных {ex.Message}");
                      }
                      
                  }));
            }
        }

    }
}
