using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Satrabel.LanguageModule.Blazor.WebAssembly;

[DependsOn(
    typeof(LanguageModuleBlazorModule),
    typeof(LanguageModuleHttpApiClientModule),
    typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
    )]
public class LanguageModuleBlazorWebAssemblyModule : AbpModule
{

}
