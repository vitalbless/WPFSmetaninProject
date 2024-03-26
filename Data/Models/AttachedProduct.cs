using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSmetaninProject.Data.Models
{
    class AttachedProduct
    {
        public int Id { get; set; }
        public int MainProductId { get; set; }
        public int ProductId { get; set; }
    }
}
