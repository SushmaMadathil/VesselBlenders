using System;
using System.Collections.Generic;

namespace VesselBlenders.Models
{
    public partial class Invoice
    {
        public int InvId { get; set; }
        public DateTime? InvDate { get; set; }
        public string DueDate { get; set; }
        public decimal? InvAmt { get; set; }
        public int? CustId { get; set; }
        public int? OrderId { get; set; }
    }
}
