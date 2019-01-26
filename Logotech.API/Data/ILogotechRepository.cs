using System.Collections.Generic;
using System.Threading.Tasks;
using Logotech.API.Models;

namespace Logotech.API.Data
{
    public interface ILogotechRepository
    {
        void add<T>(T entity) where T: class;
        void Delete<T>(T entity) where T: class;
        Task<bool> SaveAll();
        Task<IEnumerable<Praticien>> GetPraticiens();
        Task<Praticien> GetPraticien(int id);

    }
}