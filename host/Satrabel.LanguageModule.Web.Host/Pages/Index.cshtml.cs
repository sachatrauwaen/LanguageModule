using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;

namespace Satrabel.LanguageModule.Pages;

public class IndexModel : LanguageModulePageModel
{
    public void OnGet()
    {

    }

    public async Task OnPostLoginAsync()
    {
        await HttpContext.ChallengeAsync("oidc");
    }
}
