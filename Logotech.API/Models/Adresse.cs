using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Logotech.API.Models
{
    public class Adresse
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Nom de rue requis.")]
        [StringLength(55)]
        [Display(Name = "Nom de rue")]
        public string Rue { get; set; }

        [Required(ErrorMessage = "Numéro de rue requis.")]
        [Display(Name = "Numéro de rue")]
        public int NumeroRue { get; set; }

        [Display(Name = "Boîte postal")]
        public int? BoitePostal { get; set; }

        [Required(ErrorMessage = "Code Postal requis.")]
        [Display(Name = "Code postal")]
        public int CodePostal { get; set; }

        [Required(ErrorMessage = "Ville requise.")]
        [StringLength(55)]
        [Display(Name = "Ville")]
        public string Ville { get; set; }

        [Required(ErrorMessage = "Pays requis.")]
        [StringLength(55)]
        [Display(Name = "Pays")]
        public string Pays { get; set; }
    }
}