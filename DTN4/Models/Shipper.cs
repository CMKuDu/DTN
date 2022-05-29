﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DTN4.Models
{
    public partial class Shipper
    {
        public int ShipperId { get; set; }
        public string ShipperPhone { get; set; }
        public string Company { get; set; }
        public DateTime? ShipDate { get; set; }
        public string ShipperName { get; set; }
    }
}
