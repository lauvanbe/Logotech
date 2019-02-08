using System.ComponentModel.DataAnnotations;

namespace Logotech.API.Models
{
    public class Fonction
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le nom de la fonction est requis.")]
        [Display(Name = "Nom de la fonction")]
        [StringLength(55)]
        public string Nom { get; set; }

    }
}