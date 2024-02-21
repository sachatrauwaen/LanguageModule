using Satrabel.LanguageModule.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Satrabel.LanguageModule.Permissions;

public class LanguageModulePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var LanguageGroup = context.AddGroup(LanguageModulePermissions.GroupName, L("Permission:LanguageModule"));
        var LanguagePermission = LanguageGroup.AddPermission(LanguageModulePermissions.Language.Default, L("Permission:Language"));
        LanguagePermission.AddChild(LanguageModulePermissions.Language.Create, L("Permission:Language.Create"), multiTenancySide: MultiTenancySides.Both);
        LanguagePermission.AddChild(LanguageModulePermissions.Language.Edit, L("Permission:Language.Edit"), multiTenancySide: MultiTenancySides.Both);
        LanguagePermission.AddChild(LanguageModulePermissions.Language.Delete, L("Permission:Language.Delete"), multiTenancySide: MultiTenancySides.Both);
        LanguagePermission.AddChild(LanguageModulePermissions.Language.SetDefault, L("Permission:Language.SetDefault"), multiTenancySide: MultiTenancySides.Both);
    }
    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<LanguageModuleResource>(name);
    }
}
