using Satrabel.LanguageModule.Localization;
using Volo.Abp.Application.Services;

namespace Satrabel.LanguageModule;

public abstract class LanguageModuleAppService : ApplicationService
{
    protected LanguageModuleAppService()
    {
        LocalizationResource = typeof(LanguageModuleResource);
        ObjectMapperContext = typeof(LanguageModuleApplicationModule);
    }
}
