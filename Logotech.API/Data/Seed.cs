using System.Collections.Generic;
using Logotech.API.Models;
using Newtonsoft.Json;

namespace Logotech.API.Data
{
    public class Seed
    {
        private readonly DataContext _context;
        public Seed(DataContext context)
        {
            _context = context;
        }

        // public void SeedAdresse()
        // {
        //     var adresseData = System.IO.File.ReadAllText("Data/SeedDataAdresse.json");
        //     var adresses = JsonConvert.DeserializeObject<List<Adresse>>(adresseData);
        //     foreach (var adresse in adresses)
        //     {
        //         _context.Adresses.Add(adresse);
        //     }
            
        //     _context.SaveChanges();
        // }

        public void SeedUsers()
        {
            var userData = System.IO.File.ReadAllText("Data/SeedDataUser.json");
            var users = JsonConvert.DeserializeObject<List<User>>(userData);
            foreach (var user in users)
            {
                byte [] passwordHash, passwordSalt;
                CreatePasswordHash("password", out passwordHash, out passwordSalt);

                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                user.Username = user.Username.ToLower();
                
                _context.Users.Add(user);
            }
            
            _context.SaveChanges();
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using(var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
            
        }
        public void SeedDocteur()
        {
            var docteurData = System.IO.File.ReadAllText("Data/SeedDataDocteur.json");
            var docteurs = JsonConvert.DeserializeObject<List<Docteur>>(docteurData);
            foreach (var docteur in docteurs)
            {
                _context.Docteurs.Add(docteur);
            }
            
            _context.SaveChanges();
        }

        public void SeedPatient()
        {
            var patientData = System.IO.File.ReadAllText("Data/SeedDataPatient.json");
            var patients = JsonConvert.DeserializeObject<List<Patient>>(patientData);
            foreach (var patient in patients)
            {
                _context.Patients.Add(patient);
            }
            
            _context.SaveChanges();
        }
    }
}