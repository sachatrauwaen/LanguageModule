using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using Satrabel.LanguageModule.Languages;
using Microsoft.AspNetCore.Authorization;
using Satrabel.LanguageModule.Permissions;
using Volo.Abp.Settings;
using Volo.Abp.Localization;
using Volo.Abp.SettingManagement;
using Microsoft.Extensions.Caching.Distributed;
using Satrabel.LanguageModule.Providers;
using Volo.Abp.Caching;
namespace Satrabel.LanguageModule.Languages
{

    [Authorize(LanguageModulePermissions.Language.Default)]
    public class LanguageAppService :
    CrudAppService<
        Language, //The Book entity
        LanguageDto, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateLanguageDto>, //Used to create/update a book
     ILanguageAppService //implement the IBookAppService
    {
        
        private readonly ISettingManager _settingManager;
        private readonly IDistributedCache<List<LanguageCacheItem>> _cache;
        public LanguageAppService(IRepository<Language, Guid> repository,
            ISettingManager settingManager, IDistributedCache<List<LanguageCacheItem>> cache)
            : base(repository)
        {
            _settingManager = settingManager;
            _cache = cache;
        }
        public async Task SetDefaultLanguageAsync(string cultureName)
        {
            if (CurrentTenant.Id.HasValue) { await _settingManager.SetForTenantAsync(CurrentTenant.Id.Value, LocalizationSettingNames.DefaultLanguage, cultureName); 
            
            }
            else
            {
                await _settingManager.SetGlobalAsync(LocalizationSettingNames.DefaultLanguage, cultureName);
            }
        }
        public async Task<string> GetDefaultLanguageAsync()
        { 
            var defaultLanguage = await SettingProvider.GetOrNullAsync(LocalizationSettingNames.DefaultLanguage);
            return defaultLanguage ?? "Not Set"; 
        }
        public override async Task<LanguageDto> CreateAsync(CreateUpdateLanguageDto input)
        {
            var result = await base.CreateAsync(input);
            var cacheKey = LanguageCacheManager.GetLanguageKey(CurrentTenant.Id);
            await _cache.RemoveAsync(cacheKey);
            return result;
        }
        public override async Task<LanguageDto> UpdateAsync(Guid id, CreateUpdateLanguageDto input)
        {

            var result = await base.UpdateAsync(id, input);
            var cacheKey = LanguageCacheManager.GetLanguageKey(CurrentTenant.Id);
            await _cache.RemoveAsync(cacheKey);
            return result;
        }
        public override async Task DeleteAsync(Guid id)
        {
            await base.DeleteAsync(id);
            var cacheKey = LanguageCacheManager.GetLanguageKey(CurrentTenant.Id);
            await _cache.RemoveAsync(cacheKey);
        }

    }
}
