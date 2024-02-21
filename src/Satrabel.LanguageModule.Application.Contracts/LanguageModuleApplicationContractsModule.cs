using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace Satrabel.LanguageModule;

[DependsOn(
    typeof(LanguageModuleDomainSharedModule),
    typeof(AbpDddApplicationContractsModule),
    typeof(AbpAuthorizationModule)
    )]
public class LanguageModuleApplicationContractsModule : AbpModule
{

}
