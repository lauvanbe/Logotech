using System.ComponentModel.DataAnnotations;

namespace Logotech.API.Models
{
    public class Specialisation
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom de la spécialisation est requis.")]
        [Display(Name = "Nom de la spécialisation")]
        [StringLength(55)]
        public string Nom { get; set; }
    }
}