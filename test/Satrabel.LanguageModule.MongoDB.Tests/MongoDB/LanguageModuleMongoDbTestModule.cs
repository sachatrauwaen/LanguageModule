using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace Satrabel.LanguageModule.MongoDB;

[DependsOn(
    typeof(LanguageModuleApplicationTestModule),
    typeof(LanguageModuleMongoDbModule)
)]
public class LanguageModuleMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
        });
    }
}
