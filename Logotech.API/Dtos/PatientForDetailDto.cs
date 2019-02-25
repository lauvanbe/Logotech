using System;
using System.Collections.Generic;
using Logotech.API.Models;

namespace Logotech.API.Dtos
{
    public class PatientForDetailDto
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
        public String Lateralite { get; set; }
        public string Commentaire { get; set; }
        public Adresse Adresse { get; set; }
        public string PhotoUrl { get; set; }
        public ICollection<PhotoForDetailDto> Photos { get; set; }
    }
}