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
    }
}