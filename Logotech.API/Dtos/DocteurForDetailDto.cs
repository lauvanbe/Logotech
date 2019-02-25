using System.Collections.Generic;
using Logotech.API.Models;

namespace Logotech.API.Dtos
{
    public class DocteurForDetailDto
    {
        public int Id { get; set; }
        public int Inami { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int TelFixe { get; set; }
        public int Gsm { get; set; }
        public Adresse Adresse { get; set; }
        public string Specialisation { get; set; }
        public string Fonction { get; set; }
    }
}