using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Satrabel.LanguageModule.MongoDB;

[ConnectionStringName(LanguageModuleDbProperties.ConnectionStringName)]
public interface ILanguageModuleMongoDbContext : IAbpMongoDbContext
{
    /* Define mongo collections here. Example:
     * IMongoCollection<Question> Questions { get; }
     */
}
