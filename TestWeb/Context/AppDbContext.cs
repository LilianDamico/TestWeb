using Microsoft.EntityFrameworkCore;
using TestWeb.Models;

namespace TestWeb.Context
{
    public class AppDbContext : DbContext 
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Container> Container { get; set; }

        public DbSet<Movimentation> Movimentation { get; set;}

        public DbSet<LoginPage> LoginPage { get; set; }
        
    }
}
