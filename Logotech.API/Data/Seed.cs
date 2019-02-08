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
        
        public void SeedLateralite()
        {
            var lateraliteData = System.IO.File.ReadAllText("Data/SeedDataLateralite.json");
            var lateralites = JsonConvert.DeserializeObject<List<Lateralite>>(lateraliteData);
            foreach (var lateralite in lateralites)
            {
                _context.Lateralites.Add(lateralite);
            }
            
            _context.SaveChanges();
        }

        public void SeedFonction()
        {
            var fonctionData = System.IO.File.ReadAllText("Data/SeedDataFonction.json");
            var fonctions = JsonConvert.DeserializeObject<List<Fonction>>(fonctionData);
            foreach (var fonction in fonctions)
            {
                _context.Fonctions.Add(fonction);
            }
            
            _context.SaveChanges();
        }

        public void SeedSpecialisation()
        {
            var specialisationData = System.IO.File.ReadAllText("Data/SeedDataSpecialisation.json");
            var specialisations = JsonConvert.DeserializeObject<List<Specialisation>>(specialisationData);
            foreach (var specialisation in specialisations)
            {
                _context.Specialisations.Add(specialisation);
            }
            
            _context.SaveChanges();
        }

        public void SeedAdresse()
        {
            var adresseData = System.IO.File.ReadAllText("Data/SeedDataAdresse.json");
            var adresses = JsonConvert.DeserializeObject<List<Adresse>>(adresseData);
            foreach (var adresse in adresses)
            {
                _context.Adresses.Add(adresse);
            }
            
            _context.SaveChanges();
        }

        public void SeedPraticien()
        {
            var praticienData = System.IO.File.ReadAllText("Data/SeedDataPraticien.json");
            var praticiens = JsonConvert.DeserializeObject<List<Praticien>>(praticienData);
            foreach (var praticien in praticiens)
            {
                _context.Praticiens.Add(praticien);
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