using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesselBlenders.Models
{
    public class Vessel_status
    {
        public int vessel_status_id { get; set; }
        public int vessel_id { get; set; }
        public int order_id { get; set; }
        public DateTime atb { get; set; }
        public DateTime ats { get; set; }
        public DateTime ate { get; set; }

    }
}
