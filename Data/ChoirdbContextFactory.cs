using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ChoirManager.Models;

namespace ChoirManager.Data
{
    public class ChoirDbContextFactory : IDesignTimeDbContextFactory<ChoirDbContext>
    {
        public ChoirDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ChoirDbContext>();
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=ChoirManagerDb;Username=postgres;Password=Restless1996");

            return new ChoirDbContext(optionsBuilder.Options);
        }
    }
}
