using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSmetaninProject.Data.Models
{
    class ClientService
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int ServiceId { get; set; }
        public TimeSpan StartTime { get; set; }
        public string Comment { get; set; }
        public int ProductSaleId { get; set; }
        public List<DocumentByService> DocumentByServices { get; set; }
    }
}
