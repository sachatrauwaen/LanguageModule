using Microsoft.AspNetCore.Authorization;
using Satrabel.LanguageModule.Localization;
using Satrabel.LanguageModule.Permissions;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.UI.Navigation;

namespace Satrabel.LanguageModule.Web.Menus;

public class LanguageModuleMenuContributor : IMenuContributor
{

    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }
    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var l = context.GetLocalizer<LanguageModuleResource>();
        // Add main menu items.
        var administrationMenu = context.Menu.Items.SingleOrDefault(m => m.Name == "Abp.Application.Main.Administration");
        if (administrationMenu != null)
        {
            var hasPermission = await context.AuthorizationService.IsGrantedAsync(LanguageModulePermissions.Language.Default);
            if (hasPermission)
            {
                administrationMenu.AddItem(
                    new ApplicationMenuItem(
                        LanguageModuleMenus.Languages,
                        l["Menu:Languages"],
                        icon: "fa fa-language",
                        url: "/LanguageModule"
                    )
                );
            }
        }
    }
}
