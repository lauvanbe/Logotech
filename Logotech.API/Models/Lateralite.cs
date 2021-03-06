using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Logotech.API.Models
{
    public class Lateralite
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Latéralité requise.")]
        [StringLength(55)]
        [Display(Name = "Latéralité")]
        public string nom { get; set; }
    }
}