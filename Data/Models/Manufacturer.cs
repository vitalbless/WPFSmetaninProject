using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSmetaninProject.Data.Models
{
    class Manufacturer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();
    }
}
