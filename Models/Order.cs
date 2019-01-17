using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesselBlenders.Models
{
    public class Order
    {
        public int order_id { get; set; }
        public int cut_id { get; set; }
        public int vessel_id { get; set; }
        public DateTime created_date { get; set; }
        public int emp_id { get; set; }
        public int status_id { get; set; }
        public int channel_id { get; set; }
        public int term_id { get; set; }
        public int dock_id { get; set; }
        public string agent_name { get; set; }
        public DateTime etb { get; set; }

    }
}
