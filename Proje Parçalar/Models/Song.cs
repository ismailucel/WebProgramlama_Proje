using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace G201210352.Models
{
    public class Song
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 2, ErrorMessage = "{0} En Az {2} En Fazla {1} Karakter Uzunluğunda Olmalıdır.")]
        [Required(ErrorMessage = "{0} Alanı Boş Bırakılamaz.")]
        [Display(Name = "Şarkı Adı")]
        public string SongName { get; set; }

        [Range(1, int.MaxValue)]
        public double Price { get; set; }

        public double Quantity { get; set; }

        [RegularExpression(@"^[1-9][0-9]{3}$", ErrorMessage = "{0}'ı 4 Haneli Olmalıdır. ")]
        [Required(ErrorMessage = "{0} Alanı Boş Bırakılamaz.")]
        [Display(Name = "Basım Yıl")]
        public int PublishYear { get; set; }
        public int ReleaseDate { get; set; }

        public string Description { get; set; }

        [RegularExpression(@"^[1-9][0-9]*$", ErrorMessage = "{0} En Az 1 olmalıdır.")]
        [Required(ErrorMessage = "{0} Alanı Boş Bırakılamaz.")]
        [Display(Name = "Stok")]
        public int Stock { get; set; }

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category Kategori { get; set; }

        public int? ArtistId { get; set; }
        [ForeignKey("ArtistId")]
        public Artist Artist { get; set; }

        public ICollection<Photo> Photo { get; set; }

        [Display(Name = "Eklenme Tarihi")]
        public DateTime CreateDate { get; set; }

        [Display(Name = "Aktiflik")]
        public bool Active { get; set; }


    }
}
