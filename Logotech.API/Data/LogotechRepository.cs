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

        public async Task<Praticien> GetPraticien(int id)
        {
            var praticien = await _context.Praticiens.Include(a => a.Adresse).Include(s => s.Specialisation).Include(f => f.Fonction).FirstOrDefaultAsync(p => p.Id == id);

            return praticien;
        }

        public async Task<IEnumerable<Praticien>> GetPraticiens()
        {
            var praticiens = await _context.Praticiens.Include(a => a.Adresse).Include(s => s.Specialisation).Include(f => f.Fonction).ToListAsync();

            return praticiens;
        }

        public async Task<bool> SaveAll()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}