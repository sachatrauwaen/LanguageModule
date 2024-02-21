using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Localization;
using Microsoft.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories;
using Microsoft.Extensions.Options;
using Volo.Abp.Caching;
using Microsoft.Extensions.Caching.Distributed;
using Volo.Abp.MultiTenancy;

namespace Satrabel.LanguageModule.Providers
{

    public class LanguageProvider : ILanguageProvider
    {
        private readonly IRepository<Language, Guid> _repository;
        private readonly IOptions<AbpLocalizationOptions> _options;
        private readonly IDistributedCache<List<LanguageCacheItem>> _cache; // Adjusted to cache a list of LanguageCacheItems
        private readonly ICurrentTenant _tenant;
        public LanguageProvider(
            IRepository<Language, Guid> repository,
            IOptions<AbpLocalizationOptions> options,
            IDistributedCache<List<LanguageCacheItem>> cache,
            ICurrentTenant tenant) // Combined constructor
        {
            _repository = repository;
            _options = options;
            _cache = cache;
            _tenant = tenant;
        }

        public async Task<IReadOnlyList<LanguageInfo>> GetLanguagesAsync()
        {
            var cacheKey = LanguageCacheManager.GetLanguageKey(_tenant.Id);
            var cachedLanguages = await _cache.GetAsync(cacheKey);
            if (cachedLanguages == null)
            {
                var languageEntities = await _repository.GetListAsync();
                var languages = languageEntities.Select(lang => new LanguageInfo(
                    lang.CultureName,
                    lang.UiCultureName,
                    lang.DisplayName,
                    lang.FlagIcon)).OrderBy(l => l.DisplayName).ToList();

                var languageCacheItems = languages.Select(lang => new LanguageCacheItem
                {
                    CultureName = lang.CultureName,
                    UiCultureName = lang.UiCultureName,
                    DisplayName = lang.DisplayName,
                    FlagIcon = lang.FlagIcon
                }).ToList();

                await _cache.SetAsync(cacheKey, languageCacheItems, new DistributedCacheEntryOptions
                {
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(24)
                });

                return languages;
            }
            else
            {

                return cachedLanguages.Select(item => new LanguageInfo(
                    item.CultureName,
                    item.UiCultureName,
                    item.DisplayName,
                    item.FlagIcon)).ToList();
            }
        }
    }
}
