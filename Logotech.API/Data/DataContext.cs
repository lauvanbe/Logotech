using Logotech.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Logotech.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options){  }

        public DbSet<Logopede> Logopedes { get; set; }
        public DbSet<User> Users { get; set; }
    }
}