﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Models
{
    public class Order
    {
        public int Id { get; set; }
        public List<Product> OrderItems {get; set; }

    }
}
