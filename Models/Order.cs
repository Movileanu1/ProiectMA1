﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProiectMA.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int CarID { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public Car Car{ get; set; }
    }
}
