using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace G201210352.Models
{
    public class Basket
    {
        public int Id { get; set; }

        public int? SongId { get; set; }
        [ForeignKey("SongId")]
        public Song Song { get; set; }

        public string CustomerId { get; set; }
        [ForeignKey("CustomerId")]
        public ApplicationUser ApplicationUser { get; set; }

        public double Price { get; set; }

        public double Amount { get; set; }

        public bool IsOrderOk { get; set; } = false;

        [NotMapped]
        public double TotalPrice
        {
            get
            {
                return Price * Amount;
            }
        }


        [Display(Name = "Aktiflik")]
        public bool Active { get; set; }


    }
}
