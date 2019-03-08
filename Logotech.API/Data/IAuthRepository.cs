using System.Collections.Generic;
using System.Threading.Tasks;
using Logotech.API.Models;

namespace Logotech.API.Data
{
    public interface IAuthRepository
    {
         Task<User> Register(User user, string password);
         Task<User> Login(string username, string password);
         Task<bool> UserExists(string username);
         Task<IEnumerable<User>> GetUsers();

         Task<User> GetUser(int id);
    }
}