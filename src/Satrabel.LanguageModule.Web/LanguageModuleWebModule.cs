using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.DependencyInjection;
using Satrabel.LanguageModule.Localization;
using Satrabel.LanguageModule.Web.Menus;
using Volo.Abp.AspNetCore.Mvc.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;
using Volo.Abp.VirtualFileSystem;
using Satrabel.LanguageModule.Permissions;
using Volo.Abp.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Satrabel.LanguageModule.Providers;
using Volo.Abp.Localization;

namespace Satrabel.LanguageModule.Web;

[DependsOn(
    typeof(LanguageModuleApplicationContractsModule),
    typeof(LanguageModuleApplicationModule),
    typeof(AbpAspNetCoreMvcUiThemeSharedModule),
    typeof(AbpAutoMapperModule)
    )]
public class LanguageModuleWebModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.PreConfigure<AbpMvcDataAnnotationsLocalizationOptions>(options =>
        {
            options.AddAssemblyResource(typeof(LanguageModuleResource), typeof(LanguageModuleWebModule).Assembly);
        });

        PreConfigure<IMvcBuilder>(mvcBuilder =>
        {
            mvcBuilder.AddApplicationPartIfNotExists(typeof(LanguageModuleWebModule).Assembly);
        });

    }

    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new LanguageModuleMenuContributor());
        });

        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<LanguageModuleWebModule>();
        });

        context.Services.AddAutoMapperObjectMapper<LanguageModuleWebModule>();
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<LanguageModuleWebModule>(validate: false);
        });

        Configure<RazorPagesOptions>(options =>
        {
            //Configure authorization.
        });
        Configure<AbpAspNetCoreMvcOptions>(options =>
        {
            options.ConventionalControllers.Create(typeof(LanguageModuleApplicationModule).Assembly);
        });
        context.Services.Replace(ServiceDescriptor.Transient<ILanguageProvider, LanguageProvider>());


        Configure<AbpLocalizationOptions>(options =>
        {
            
        });
    }
}
