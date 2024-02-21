using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Satrabel.LanguageModule;

[DependsOn(
    typeof(AbpVirtualFileSystemModule)
    )]
public class LanguageModuleInstallerModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpVirtualFileSystemOptions>(options =>
        {
            options.FileSets.AddEmbedded<LanguageModuleInstallerModule>();
        });
    }
}
