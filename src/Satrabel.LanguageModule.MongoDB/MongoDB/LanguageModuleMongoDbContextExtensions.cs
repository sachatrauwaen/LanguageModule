using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Satrabel.LanguageModule.MongoDB;

public static class LanguageModuleMongoDbContextExtensions
{
    public static void ConfigureLanguageModule(
        this IMongoModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));
    }
}
