﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFSmetaninProject.Data.Models
{
    public class Tag
    {
        public int Id{ get; set; }
        public string Title { get; set; }
        public string Color { get; set; }
        public List<TagOfClient> TagOfClients { get; set; } = new List<TagOfClient>();
    }
}
