using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesselBlenders.Models
{
    public class shore_loading_plan
    {
        public int shank_id { get; set; }
        public int order_id { get; set; }
        public int total_vol { get; set; }
    }
}
