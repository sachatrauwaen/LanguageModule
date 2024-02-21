using Volo.Abp.Modularity;

namespace Satrabel.LanguageModule;

[DependsOn(
    typeof(LanguageModuleApplicationModule),
    typeof(LanguageModuleDomainTestModule)
    )]
public class LanguageModuleApplicationTestModule : AbpModule
{

}
