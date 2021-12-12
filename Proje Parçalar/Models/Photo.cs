using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace G201210352.Models
{
    public class Photo
    {
        public int Id { get; set; }

        public string SongName { get; set; }

        public int? SongId { get; set; }
        [ForeignKey("SongId")]
        public Song Song { get; set; }
    }
}
