using AutoMapper;
using Satrabel.LanguageModule.Languages;

namespace Satrabel.LanguageModule;

public class LanguageModuleApplicationAutoMapperProfile : Profile
{
    public LanguageModuleApplicationAutoMapperProfile()
    {
        CreateMap<Language, LanguageDto>();
        CreateMap<CreateUpdateLanguageDto, Language>()
            .ForMember(l => l.TenantId, opt => opt.Ignore()); ;
        CreateMap<LanguageDto, CreateUpdateLanguageDto>();
    }
}
