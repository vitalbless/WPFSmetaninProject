﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSmetaninProject.Data.Models
{
     public class ProductPhoto
    {
        public int Id { get; set; }
        public int ProductId{ get; set; }
        public string PhotoPath { get; set; }
    }
}
