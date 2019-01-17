using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesselBlenders.Models
{
    public class shore_vol_trans
    {
        public int order_id { get; set; }
        public int shtank_id { get; set; }
        public int act_vol { get; set; }
        public DateTime act_date { get; set; }
    }
}
