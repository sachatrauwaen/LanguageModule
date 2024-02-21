using AutoMapper;
using Satrabel.LanguageModule.Languages;
using static Satrabel.LanguageModule.Pages.LanguageOptions.EditModalModel;

namespace Satrabel.LanguageModule.Web;

public class LanguageModuleWebAutoMapperProfile : Profile
{
    public LanguageModuleWebAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
       CreateMap<EditLanguageVieuwModel, CreateUpdateLanguageDto>();
        CreateMap<LanguageDto, EditLanguageVieuwModel>();
    }
}
