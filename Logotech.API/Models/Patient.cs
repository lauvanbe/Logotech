using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Logotech.API.Models
{
    public class Patient
    {
       public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }

        public DateTime DateNaissance { get; set; }

        public string Email { get; set; }

        public int? TelFixe { get; set; }

        public int? Gsm { get; set; }

        public string PersonneContact { get; set; }

        public int? TelContact { get; set; }

        public string Anamnese { get; set; }

        public string Lateralite { get; set; }

        public string Commentaire { get; set; }

        public Adresse Adresse { get; set; }

        public ICollection<Photo> Photos { get; set; }
    }
}
