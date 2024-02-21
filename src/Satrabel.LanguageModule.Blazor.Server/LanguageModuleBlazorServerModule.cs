using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Satrabel.LanguageModule.Blazor.Server;

[DependsOn(
    typeof(AbpAspNetCoreComponentsServerThemingModule),
    typeof(LanguageModuleBlazorModule)
    )]
public class LanguageModuleBlazorServerModule : AbpModule
{

}
