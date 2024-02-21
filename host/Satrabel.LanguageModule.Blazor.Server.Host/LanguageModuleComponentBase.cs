using Satrabel.LanguageModule.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Satrabel.LanguageModule.Blazor.Server.Host;

public abstract class LanguageModuleComponentBase : AbpComponentBase
{
    protected LanguageModuleComponentBase()
    {
        LocalizationResource = typeof(LanguageModuleResource);
    }
}
