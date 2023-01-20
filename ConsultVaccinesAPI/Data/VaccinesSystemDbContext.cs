using Microsoft.EntityFrameworkCore;
using ConsultVaccinesAPI.Models;
using ConsultVaccinesAPI.Data.Map;

namespace ConsultVaccinesAPI.Data
{
    public class VaccinesSystemDbContext: DbContext 
    {
        public VaccinesSystemDbContext(DbContextOptions<VaccinesSystemDbContext> options)
            : base(options) 
        {
        }

        public DbSet<UserModel> Users { get; set; }
        public DbSet<VaccinesModel> Vaccines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new VaccinesMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
