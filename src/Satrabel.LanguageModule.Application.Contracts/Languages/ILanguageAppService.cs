using Satrabel.LanguageModule.Languages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Satrabel.LanguageModule
{
    public interface ILanguageAppService : IApplicationService
    {
        Task<LanguageDto> GetAsync(Guid id);
        Task<PagedResultDto<LanguageDto>> GetListAsync(PagedAndSortedResultRequestDto input);
        Task<LanguageDto> CreateAsync(CreateUpdateLanguageDto input);
        Task<LanguageDto> UpdateAsync(Guid id, CreateUpdateLanguageDto input);
        Task DeleteAsync(Guid id);

    }
}
