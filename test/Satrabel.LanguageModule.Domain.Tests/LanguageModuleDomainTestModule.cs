using Volo.Abp.Modularity;

namespace Satrabel.LanguageModule;

[DependsOn(
   /* typeof(LanguageModuleDomainModule),*/
    typeof(LanguageModuleTestBaseModule)
)]
public class LanguageModuleDomainTestModule : AbpModule
{

}
