using Microsoft.EntityFrameworkCore;
using BloodBank.Configuration;
using BloodBank.Models;

namespace BloodBank.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CityConfig());

        }
        public DbSet<BloodBank.Models.User> Users { get; set; }
        public DbSet<BloodBank.Models.Admin> Admins { get; set; }
        public DbSet<BloodBank.Models.Hospital> Hospitals { get; set; }
        public DbSet<BloodBank.Models.Transaction> Transactions { get; set; }
        public DbSet<BloodBank.Models.Blood_data> Bloods { get; set; }
        public DbSet<BloodBank.Models.Employee> Employees { get; set; }
        public DbSet<BloodBank.Models.City> Cities { get; set; }
        

    }
   
}
