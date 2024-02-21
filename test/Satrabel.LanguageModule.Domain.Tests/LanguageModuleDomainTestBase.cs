using Volo.Abp.Modularity;

namespace Satrabel.LanguageModule;

/* Inherit from this class for your domain layer tests.
 * See SampleManager_Tests for example.
 */
public abstract class LanguageModuleDomainTestBase<TStartupModule> : LanguageModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
