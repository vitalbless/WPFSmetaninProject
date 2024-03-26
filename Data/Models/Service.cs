using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSmetaninProject.Data.Models
{
    class Service
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Cost { get; set; }
        public int DurationInSeconds { get; set; }
        public string Description{ get; set; }
        public int Discount { get; set; }
        public string MainImagePath { get; set; }
        public List<ClientService> ClientServices { get; set; } = new List<ClientService>();
        public List<ServicePhoto> ServicePhotos { get; set; } = new List<ServicePhoto>();
    }
}
