using System.ComponentModel.DataAnnotations;
using Logotech.API.Models;

namespace Logotech.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "Le nom d'utilisateur est requis")]
        public string Username { get; set; }

        [Required (ErrorMessage = "Le mot de passe est requis")]
        [StringLength(8,MinimumLength = 4, ErrorMessage = "Le mot de passe doit être compris entre 4 et 8 caractères")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Le numéro INAMI est requis.")]
        [Display(Name = "Numéro INAMI")]
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
        public int? TelFixe { get; set; }

        [Display(Name = "Gsm")]
        public int? Gsm { get; set; }

        [Required(ErrorMessage = "Veuillez spécifier si les déplacements sont possible.")]
        [Display(Name = "Visites à domicile")]
        public string Deplacement { get; set; }

        public Adresse Adresse { get; set; }
    }
}
