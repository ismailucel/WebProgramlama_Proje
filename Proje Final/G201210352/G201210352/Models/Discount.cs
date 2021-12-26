using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G201210352.Models
{
    public class Discount
    {
        public int Id { get; set; }

        public string Name { get; set; }  //IND25, KARGO

        public DateTime DiscountStartDate { get; set; } //23.11

        public DateTime DiscountEndDate { get; set; }//25.11

        public double DiscountRate { get; set; }//100

        public double MinimumValue { get; set; }//500
    }
}
