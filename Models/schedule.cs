using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VesselBlenders.Models
{
    public class schedule
    {
        public int sch_id { get; set; }
        public int emp_id { get; set; }
        public DateTime start_date { get; set; }
        public DateTime end_date { get; set; }
        public int channel_id { get; set; }
        public int term_id { get; set; }
        public int dock_id { get; set; }
        public int vessel_id { get; set; }


    }
}
