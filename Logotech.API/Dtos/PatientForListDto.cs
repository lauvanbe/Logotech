using System;

namespace Logotech.API.Dtos
{
    public class PatientForListDto
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
        public string Commentaire { get; set; }
        public string PhotoUrl { get; set; }
    }
}