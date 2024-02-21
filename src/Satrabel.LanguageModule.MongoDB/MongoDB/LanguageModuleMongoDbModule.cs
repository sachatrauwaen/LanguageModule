using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Satrabel.LanguageModule.MongoDB;

[DependsOn(
    /*typeof(LanguageModuleDomainModule),*/
    typeof(AbpMongoDbModule)
    )]
public class LanguageModuleMongoDbModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMongoDbContext<LanguageModuleMongoDbContext>(options =>
        {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
        });
    }
}
