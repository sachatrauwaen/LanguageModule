using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Satrabel.LanguageModule;

[DependsOn(
    typeof(LanguageModuleApplicationContractsModule),
    typeof(AbpHttpClientModule))]
public class LanguageModuleHttpApiClientModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddHttpClientProxies(
            typeof(LanguageModuleApplicationContractsModule).Assembly,
            LanguageModuleRemoteServiceConsts.RemoteServiceName
        );

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<LanguageModuleHttpApiClientModule>();
        });

    }
}
