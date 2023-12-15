using DevFest.Api.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace DevFest.Api.Data
{
    public class AppDbContext : DbContext
    {
        public IConfiguration _Configuration { get; set; }
        public AppDbContext(IConfiguration configuration)
        {
            _Configuration = configuration;
        }


        public DbSet<User> Users { get; set; }
        public DbSet<User> Tag { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_Configuration.GetConnectionString("DefaultConnection"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
