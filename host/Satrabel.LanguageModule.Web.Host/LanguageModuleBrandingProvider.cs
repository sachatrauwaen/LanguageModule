using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace Satrabel.LanguageModule;

[Dependency(ReplaceServices = true)]
public class LanguageModuleBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "LanguageModule";
}
