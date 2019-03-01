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
        Task<IEnumerable<Docteur>> GetDocteurs();
        Task<Docteur> GetDocteur(int id);
        Task<IEnumerable<Patient>> GetPatients();
        Task<Patient> GetPatient(int id);
        Task<Photo> GetPhoto(int id);

    }
}