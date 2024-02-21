using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Satrabel.LanguageModule.EntityFrameworkCore;

[ConnectionStringName(LanguageModuleDbProperties.ConnectionStringName)]
public class LanguageModuleDbContext : AbpDbContext<LanguageModuleDbContext>, ILanguageModuleDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * public DbSet<Question> Questions { get; set; }
     */

    public DbSet<Language> Language { get; set; }

    public LanguageModuleDbContext(DbContextOptions<LanguageModuleDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.ConfigureLanguageModule();
       
    }
}
