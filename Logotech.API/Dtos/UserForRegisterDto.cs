using System.ComponentModel.DataAnnotations;

namespace Logotech.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required(ErrorMessage = "Le nom d'utilisateur est requis")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Le mot de passe est requis")]
        [StringLength(8,MinimumLength = 4, ErrorMessage = "Le mot de passedoit être compris entre 4 et 8 caractères")]
        public string Password { get; set; }
    }
}