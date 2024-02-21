using Volo.Abp.Caching;

namespace Satrabel.LanguageModule.Providers
{
    [CacheName("Language")]
    public class LanguageCacheItem
    {
        public string CultureName { get; set; }
        public string UiCultureName { get; set; }
        public string DisplayName { get; set; }
        public string FlagIcon { get; set; }
    }
}
