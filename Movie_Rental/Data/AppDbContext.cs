using Microsoft.EntityFrameworkCore;
using Movie_Rental.Models;

namespace Movie_Rental.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options) : base(options) { }
       
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity => {
                entity.HasKey(c => c.CostumerId);

                //entity.HasOne()
                //.WithMany();
            });

            modelBuilder.Entity<Movie>(entity => {
                entity.HasKey(m => m.MovieId);
            });

            modelBuilder.Entity<Rental>(entity => {
                entity.HasKey(r => r.RentalId);
            });
        }
    }
}
