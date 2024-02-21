using Satrabel.LanguageModule.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Satrabel.LanguageModule.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class LanguageModulePageModel : AbpPageModel
{
    protected LanguageModulePageModel()
    {
        LocalizationResourceType = typeof(LanguageModuleResource);
        ObjectMapperContext = typeof(LanguageModuleWebModule);
    }
}
