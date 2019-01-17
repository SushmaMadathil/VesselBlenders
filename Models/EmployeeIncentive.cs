using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace VesselBlenders.Models
{
    public class EmployeeIncentive
    {
        [Key]
        public double SNo { get; set; }
        [Display(Name = " Your Total Incentive Days")]
        public double total_incentive_days { get; set; }
        [Display(Name = "Total Days of Bth")]
        public int days_of_bth { get; set; }
        [Display(Name = "Pto Days")]
        public int pto_days { get; set; }
        public static double mealallowance { get; set; }
        public static double transportationallowance { get; set; }
        [Display(Name = "Incentive Days you earned from PTO Days Used")]
        public int incentivedaysfromptodays { get; set; }
        public double meals_allowance { get; set; }
        public double Transportation_allowance { get; set; }
        public double monthlycellphonerate { get; set; }
        [Display(Name = "Flat rate of travel(Out of Town")]
        public double flatratetravel { get; set; }
        [Display(Name = "Other")]
        public double others { get; set; }
        public double grandtotal { get; set; }
        public double incentivemultipliertill10 { get; set; }
        public double incentivemultipliertill11to15 { get; set; }
        public double incentivemultiplier16plus { get; set; }
        public double hourincentiverate { get; set; }
        public double flatdayrate { get; set; }
        public double output1 { get; set; }
        public double output2 { get; set; }
        public double output3 { get; set; }
        public double output4 { get; set; }
        public double output5 { get; set; }
        public double output6 { get; set; }
        public double output7 { get; set; }
        public double output8 { get; set; }
        public double output9 { get; set; }
        public double output10 { get; set; }
        public double output11 { get; set; }
        public double output12 { get; set; }
        public double output13 { get; set; }
        public double output14 { get; set; }
        public double output15 { get; set; }
        public double output16 { get; set; }
        public double output17 { get; set; }

    }
}
