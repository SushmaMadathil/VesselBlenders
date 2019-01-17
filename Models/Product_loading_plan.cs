using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesselBlenders.Models
{
    public class Product_loading_plan
    {
        public int prod_id { get; set; }
        public int order_id { get; set; }
        public int shtank_id { get; set; }
        public int shtank_vol { get; set; }
        public int act_vol { get; set; }
        public int variance { get; set; }
    }
}
