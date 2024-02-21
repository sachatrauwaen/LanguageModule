using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Satrabel.LanguageModule.Blazor.Server.Host;

[Dependency(ReplaceServices = true)]
public class LanguageModuleBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "LanguageModule";
}
