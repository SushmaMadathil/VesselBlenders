using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesselBlenders.Models
{
    public class shore_tank
    {
        public int shtank_id { get; set; }
        public int shtank_name { get; set; }
        public int shtank_cap { get; set; }
        public int shtank_den { get; set; }
        public int dock_id { get; set; }
    }
}
