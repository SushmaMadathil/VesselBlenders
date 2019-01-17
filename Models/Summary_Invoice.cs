using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesselBlenders.Models
{
    public class Summary_Invoice
    {
        public int inv_id { get; set; }
        public int ser_id { get; set; }
        public int quantity { get; set; }
        public double amount { get; set; }
    }
}
