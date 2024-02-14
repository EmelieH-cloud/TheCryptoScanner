using Microsoft.EntityFrameworkCore;
using MyCryptoScanner.Data.Models;

namespace MyCryptoScanner.Data.DbConnection
{
    public class CoinDbContext : DbContext
    {
        public CoinDbContext(DbContextOptions<CoinDbContext> options) : base(options)
        {

        }


        public DbSet<CoinDbModel> Coins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CoinDbModel>()
                .HasKey(c => c.Id);
        }


    }
}
