using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesselBlenders.Models
{
    public class Product_loading_status
    {
        public int load_status_id { get; set; }
        public int order_id { get; set; }
        public int vtank_id { get; set; }
        public int status_id { get; set; }
        public DateTime updated_time { get; set; }

    }
}
