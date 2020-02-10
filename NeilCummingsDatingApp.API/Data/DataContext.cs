using Microsoft.EntityFrameworkCore;
using NeilCummingsDatingApp.API.Models;

namespace NeilCummingsDatingApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Values> Values { get; set; }
        public DbSet<User> Users { get; set; }

        }
}
