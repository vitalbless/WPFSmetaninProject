using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using WPFSmetaninProject.Data.Context;
using WPFSmetaninProject.Data.Core;
using WPFSmetaninProject.Data.Models;
using WPFSmetaninProject.Services;

namespace WPFSmetaninProject.Data.ViewModels
{
    class AddProductViewModel : INotifyPropertyChanged
    {
        private bool check = true;
        ApplicationContext db = new ApplicationContext();
        private string _title;
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Имя не должно содержать менее 5 символов")]
        public string Title
        {
            get { return _title; }
            set { ValidateProperty(value, "Title"); _title = value; OnPropertyChanged(); }
        }

        private void ValidateProperty<T>(T value, string name)
        {
            if (check)
            {
                Validator.ValidateProperty(value, new ValidationContext(this, null, null)
                {
                    MemberName = name
                });
            }
        }

        private int _cost;
        [Required]
        [Range(100, 100000, ErrorMessage = "Минимальная цена : 100")]
        public int Cost
        {
            get { return _cost; }
            set { ValidateProperty(value, "Cost"); _cost = value; OnPropertyChanged(); }
        }
        private string _description;

        [StringLength(50, MinimumLength = 5, ErrorMessage = "Имя не должно содержать менее 5 символов")]
        public string Description
        {
            get { return _description; }
            set { ValidateProperty(value, "Description"); _description = value; OnPropertyChanged(); }
        }
        private string _mainImagePath;
        [Required(ErrorMessage = "Поле не должно быть пустым")]
        public string MainImagePath
        {
            get { return _mainImagePath; }
            set { ValidateProperty(value, "MainImagePath"); _mainImagePath = value; OnPropertyChanged(); }
        }
        private bool _isActive = true;

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; OnPropertyChanged(); }
        }
        private int _manufacturerId;

        public int ManufacturerId
        {
            get { return _manufacturerId; }
            set { _manufacturerId = value; OnPropertyChanged(); }

        }

        public IEnumerable<Manufacturer> Manufacturers
        {
            get { return ConnectToDb.db.Manufacturers.ToList(); ; }

        }

        private RelayCommand addProduct;

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

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
                              GetFileService.CopyImageToProject();
                              SupplyMethods.SetMesssageToStatusBar($"Модель телефона {Title} успешно добавлена!");
                              check = false;
                              this.Title = string.Empty;
                              this.Description = string.Empty;
                              this.Cost = 0;
                              this.MainImagePath = string.Empty;
                              this.ManufacturerId = -1;
                              this.IsActive = true;
                              check = true;
                          }
                      }
                      catch (Exception ex)
                      {
                          SupplyMethods.SetMesssageToStatusBar($"Возникла ошибка при добавлении данных {ex.Message}");
                      }
                  }));
            }

        }
        public RelayCommand GetFilePath => new RelayCommand(obj => MainImagePath = GetFileService.GetImagePath());
    }
}
