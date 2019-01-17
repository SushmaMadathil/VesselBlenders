using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesselBlenders.Models
{
    public class Vessel_tank
    {
        public DateTime vtank_id { get; set; }
        public string vtank_name { get; set; }
        public int vessel_id { get; set; }
        public int vtank_cap { get; set; }
    }
}
