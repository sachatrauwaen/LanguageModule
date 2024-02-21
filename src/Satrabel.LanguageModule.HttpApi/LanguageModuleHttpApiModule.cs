using Localization.Resources.AbpUi;
using Satrabel.LanguageModule.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Satrabel.LanguageModule;

[DependsOn(
    typeof(LanguageModuleApplicationContractsModule),
    typeof(AbpAspNetCoreMvcModule))]
public class LanguageModuleHttpApiModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(LanguageModuleHttpApiModule).Assembly);
        });
    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<LanguageModuleResource>()
                .AddBaseTypes(typeof(AbpUiResource));
        });
    }
}
