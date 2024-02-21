using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Satrabel.LanguageModule.EntityFrameworkCore;

public class LanguageModuleHttpApiHostMigrationsDbContext : AbpDbContext<LanguageModuleHttpApiHostMigrationsDbContext>
{
    public LanguageModuleHttpApiHostMigrationsDbContext(DbContextOptions<LanguageModuleHttpApiHostMigrationsDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ConfigureLanguageModule();
    }
}
