using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetManagement_CommonLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement_DataBase
{
    public class AssetDbContext : DbContext
    {
        public DbSet<Asset> Assets { get; set; }

        //  Internal Recommendation to use a primary constructor.
        public AssetDbContext(DbContextOptions<AssetDbContext> options)
          : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // Password set in pgAdmin is '1234'
                optionsBuilder.UseNpgsql("Host=localhost;Database=AssetDb;Username=postgres;Password=1234");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Asset>().HasData(
                new Asset
                {
                    Id = "1", 
                    Name = "Office Chair",
                    Category = "Furniture",
                    Value = 1000,
                    Currency = "ZAR",
                    DateCreatedInDb = DateTime.SpecifyKind(new DateTime(2025, 1, 1), DateTimeKind.Utc),
                    Location = "Main Office"
                }
            );
        }
    }
}
