using Volo.Abp.Modularity;

namespace Satrabel.LanguageModule;

/* Inherit from this class for your application layer tests.
 * See SampleAppService_Tests for example.
 */
public abstract class LanguageModuleApplicationTestBase<TStartupModule> : LanguageModuleTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
