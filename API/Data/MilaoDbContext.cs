using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{

    public class MilaoDbContext : DbContext
    {
    public MilaoDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> User { get; set; }
    }
}