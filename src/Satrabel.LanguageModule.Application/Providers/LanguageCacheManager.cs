using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satrabel.LanguageModule.Providers
{
    internal class LanguageCacheManager
    {
        private const string LanguageCacheKeyPrefix = "LanguagesCacheKey";
        public static string GetLanguageKey(Guid? tennantId) 
        {
            if (tennantId == null)
            {
                var cacheKey = LanguageCacheKeyPrefix;
                return cacheKey;
            }
            else
            {
                var cacheKey = tennantId + LanguageCacheKeyPrefix;
                return cacheKey;
            }
        }
    }
}
