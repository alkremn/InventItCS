﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Inventory
    {
        public List<Product> Products { get; set; } = new List<Product>();

        public List<Part> Parts { get; set; } = new List<Part>();

        

    }
}
