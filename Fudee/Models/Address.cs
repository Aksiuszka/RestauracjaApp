using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Fudee.Models
{
    public class Address
    {
        [Key]
        [Display(Name = "Identyfikator:")]
        public int IdAddress { get; set; }

        [Required(ErrorMessage ="Proszę podać miejscowość:")]
        [Display(Name = "Miejscowość:")]
        [MaxLength(30, ErrorMessage = "Nazwa mejscowości nie może przekroczyć 30 znaków")]
        public string? City { get; set; }

        [Required(ErrorMessage = "Proszę podać ulicę:")]
        [Display(Name = "Ulica:")]
        [MaxLength(70, ErrorMessage = "Nazwa ulicy nie może przekroczyć 70 znaków")]
        public string? Street { get; set; }

        [Required(ErrorMessage = "Proszę podać kod pocztowy:")]
        [Display(Name = "Kod pocztowy:")]
        [StringLength(5, ErrorMessage = "Kod pocztowy musi mieć 5 znaków")]
        public string? PostCode { get; set; }

        public virtual Restaurant? Restaurant { get; set; }
       
    }
}
