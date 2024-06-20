using Microsoft.EntityFrameworkCore;

namespace LabWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Apple", Price = 10.00m, Description = "Description1" },
                new Product { Id = 2, Name = "Grapes", Price = 20.00m, Description = "Description2" },
                new Product { Id = 3, Name = "Milk", Price = 30.00m, Description = "Description3" }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
