using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace G201210352.Models
{
    public class BasketItem
    {
        public int Id { get; set; }
        public int BasketId { get; set; }
        public Basket Basket { get; set; }
        public int SongId { get; set; }
        public Song Song { get; set; }
        public bool Active { get; set; }
    }
}
