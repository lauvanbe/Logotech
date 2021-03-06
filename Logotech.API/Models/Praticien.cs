using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logotech.API.Models
{
    public class Praticien
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Le numéro INAMI est requis.")]
        [Display(Name = "Numéro INAMI")]
        [Range(1, 11)]
        public int Inami { get; set; }

        [Required(ErrorMessage = "Le nom est requis.")]
        [Display(Name = "Nom")]
        [StringLength(55)]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Le prénom est requis.")]
        [Display(Name = "Prénom")]
        [StringLength(55)]
        public string Prenom { get; set; }

        [Required(ErrorMessage = "Email du logopède requis.")]
        [Display(Name = "Adresse Email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }

        [Display(Name = "Téléphone fixe")]
        public int TelFixe { get; set; }

        [Display(Name = "Gsm")]
        public int Gsm { get; set; }

        [Required(ErrorMessage = "Veuillez spécifier si les déplacements sont possible.")]
        [Display(Name = "Visites à domicile")]
        public bool Deplacement { get; set; }

        public string PhotoUrl { get; set; }

        public Adresse Adresse { get; set; }

        [ForeignKey("Adresse")]
        public int AdresseId { get; set; }

        public Specialisation Specialisation { get; set; }

        [ForeignKey("Specialisation")]
        public int SpecialisationId { get; set; }

        public Fonction Fonction { get; set; }

        [ForeignKey("Fonction")]
        public int FonctionId { get; set; } 
    }
}
