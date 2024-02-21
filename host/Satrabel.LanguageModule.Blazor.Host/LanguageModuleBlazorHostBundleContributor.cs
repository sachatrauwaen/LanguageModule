using Volo.Abp.Bundling;

namespace Satrabel.LanguageModule.Blazor.Host;

public class LanguageModuleBlazorHostBundleContributor : IBundleContributor
{
    public void AddScripts(BundleContext context)
    {

    }

    public void AddStyles(BundleContext context)
    {
        context.Add("main.css", true);
    }
}
