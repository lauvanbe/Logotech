using Logotech.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Logotech.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){  }
        public DbSet<User> Users { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Praticien> Praticiens { get; set; }
        public DbSet<Adresse> Adresses { get; set; }
        public DbSet<Fonction> Fonctions { get; set; }
        public DbSet<Lateralite> Lateralites { get; set; }
        public DbSet<Specialisation> Specialisations { get; set; }
    }
}
