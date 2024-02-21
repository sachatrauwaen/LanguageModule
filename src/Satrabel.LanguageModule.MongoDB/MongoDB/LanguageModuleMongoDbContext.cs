using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Satrabel.LanguageModule.MongoDB;

[ConnectionStringName(LanguageModuleDbProperties.ConnectionStringName)]
public class LanguageModuleMongoDbContext : AbpMongoDbContext, ILanguageModuleMongoDbContext
{
    /* Add mongo collections here. Example:
     * public IMongoCollection<Question> Questions => Collection<Question>();
     */

    protected override void CreateModel(IMongoModelBuilder modelBuilder)
    {
        base.CreateModel(modelBuilder);

        modelBuilder.ConfigureLanguageModule();
    }
}
