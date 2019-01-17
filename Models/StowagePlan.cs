using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesselBlenders.Models
{
    public class StowagePlan
    {
        public int order_id { get; set; }
        public int vtank_id { get; set; }
        public int vtank_vol { get; set; }
        public int prod_id { get; set; }
    }
}
