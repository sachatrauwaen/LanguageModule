using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Satrabel.LanguageModule.EntityFrameworkCore;

public class LanguageModuleHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<LanguageModuleHttpApiHostMigrationsDbContext>
{
    public LanguageModuleHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<LanguageModuleHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("LanguageModule"));

        return new LanguageModuleHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
