using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql.EntityFrameworkCore.PostgreSQL;


namespace AssetManagement_DataBase
{
    public class AssetDbContextFactory : IDesignTimeDbContextFactory<AssetDbContext>
    {
        public AssetDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<AssetDbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Database=AssetDb;Username=postgres;Password=1234");

            return new AssetDbContext(optionsBuilder.Options);
        }
    }
}