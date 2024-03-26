using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSmetaninProject.Data.Models
{
    class DocumentByService
    {
        public int Id { get; set; }
        public int ClientServiceId { get; set; }
        public string DocumentPath { get; set; }
    }
}
