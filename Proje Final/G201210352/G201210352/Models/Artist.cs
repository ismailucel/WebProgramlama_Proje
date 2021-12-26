using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace G201210352.Models
{
    public class Artist
    {
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z_ğüşıöçĞÜŞİÖÇ ]+$", ErrorMessage = "Sadece harf giriniz.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "{0} En az {2} en fazla {1} karakter uzunluğunda olmalıdır.")]
        [Required(ErrorMessage = "{0} Alan boş bırakılamaz.")]
        [Display(Name = "İsim")]
        public string Name { get; set; }

        [Display(Name = "Aktiflik")]
        public bool Active { get; set; }
    }
}
