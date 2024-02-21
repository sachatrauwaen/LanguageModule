using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Satrabel.LanguageModule.EntityFrameworkCore;

[ConnectionStringName(LanguageModuleDbProperties.ConnectionStringName)]
public interface ILanguageModuleDbContext : IEfCoreDbContext
{
    /* Add DbSet for each Aggregate Root here. Example:
     * DbSet<Question> Questions { get; }
     */

    public DbSet<Language> Language { get; set; }
}
