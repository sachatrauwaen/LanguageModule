using Satrabel.LanguageModule.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Satrabel.LanguageModule;

public abstract class LanguageModuleController : AbpControllerBase
{
    protected LanguageModuleController()
    {
        LocalizationResource = typeof(LanguageModuleResource);
    }
}
