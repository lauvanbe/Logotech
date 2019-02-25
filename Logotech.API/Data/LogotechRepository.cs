using System.Collections.Generic;
using System.Threading.Tasks;
using Logotech.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Logotech.API.Data
{
    public class LogotechRepository : ILogotechRepository
    {
        private readonly DataContext _context;
        public LogotechRepository(DataContext context)
        {
            _context = context;
        }
        public void add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public async Task<Docteur> GetDocteur(int id)
        {
            var praticien = await _context.Docteurs.Include(a => a.Adresse).FirstOrDefaultAsync(p => p.Id == id);

            return praticien;
        }

        public async Task<IEnumerable<Docteur>> GetDocteurs()
        {
            var praticiens = await _context.Docteurs.ToListAsync();

            return praticiens;
        }

        public async Task<Patient> GetPatient(int id)
        {
            var patient = await _context.Patients.Include(a => a.Adresse).Include(p => p.Photos).FirstOrDefaultAsync(p => p.Id == id);

            return patient;
        }

        public async Task<IEnumerable<Patient>> GetPatients()
        {
            var patients = await _context.Patients.Include(p => p.Photos).ToListAsync();

            return patients;
        }
  
        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}