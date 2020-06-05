using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace PieeresTreats.Models
{
    public class PieeresTreatsContextFactory : IDesignTimeDbContextFactory<PieeresTreatsContext>
    {

        PieeresTreatsContext IDesignTimeDbContextFactory<PieeresTreatsContext>.CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

                var builder = new DbContextOptionsBuilder<PieeresTreatsContext>();
                var connectionString = configuration.GetConnectionString("DefaultConnection");

                builder.UseMySql(connectionString);

                return new PieeresTreatsContext(builder.Options)
        }
    }
}