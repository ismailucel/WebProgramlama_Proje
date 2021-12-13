using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace G201210352.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int? SongId { get; set; }
        [ForeignKey("SongId")]
        public Song Song { get; set; }

        public int? OrderId { get; set; }
        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        public double Quantity { get; set; }

        public double Price { get; set; }


        [NotMapped]
        public double Charge
        {
            get
            {
                return Quantity * Price;
            }
        }
    }
}
