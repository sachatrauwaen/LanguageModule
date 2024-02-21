using Satrabel.LanguageModule.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Satrabel.LanguageModule.Pages;

public abstract class LanguageModulePageModel : AbpPageModel
{
    protected LanguageModulePageModel()
    {
        LocalizationResourceType = typeof(LanguageModuleResource);
    }
}
