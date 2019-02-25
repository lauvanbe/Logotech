namespace Logotech.API.Dtos
{
    public class DocteurForListDto
    {
        public int Id { get; set; }
        public int Inami { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Email { get; set; }
        public int TelFixe { get; set; }
        public int Gsm { get; set; }
        public bool Deplacement { get; set; }  
    }
}