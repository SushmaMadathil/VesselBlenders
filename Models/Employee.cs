using System;
using System.Collections.Generic;

namespace VesselBlenders.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }
        public string EmpFname { get; set; }
        public string EmpLname { get; set; }
        public string EmpTitle { get; set; }
        public string EmpEmail { get; set; }
        public string EmpPhone { get; set; }
        public DateTime? EmpHdate { get; set; }
        public int? EmpSal { get; set; }
    }
}
