using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSmetaninProject.Data.Models
{
    class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Cost { get; set; }
        public string Description { get; set; }
        public int MainImagePath { get; set; }
        public bool IsActive { get; set; }
        public int ManufacturerId { get; set; }
        public List<ProductSale> ProductSales { get; set; }
        public List<AttachedProduct> AttachedProducts { get; set; }
        public List<ProductPhoto> ProductPhotos { get; set; }
    }
}
