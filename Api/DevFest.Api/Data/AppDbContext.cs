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


        public DbSet<User_DataLayer> Users { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Idea> Ideas { get; set; }
        public DbSet<ProjectInDataLayer> Projects { get; set; }
        public DbSet<UserInProject> UserInProjects { get; set; }
        public DbSet<Help> Helps { get; set; }
        public DbSet<XHaveTag> XHaveTags { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_Configuration.GetConnectionString("DefaultConnection"));
            base.OnConfiguring(optionsBuilder);
        }
    }
}
