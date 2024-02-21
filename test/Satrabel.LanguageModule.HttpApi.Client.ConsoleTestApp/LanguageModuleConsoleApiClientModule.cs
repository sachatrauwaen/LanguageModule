using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Satrabel.LanguageModule;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(LanguageModuleHttpApiClientModule),
    typeof(AbpHttpClientIdentityModelModule)
    )]
public class LanguageModuleConsoleApiClientModule : AbpModule
{

}
