using Volo.Abp.Reflection;

namespace Satrabel.LanguageModule.Permissions;

public class LanguageModulePermissions
{
    public const string GroupName = "LanguageModule";
    public static class Language
    {
        public const string Default = GroupName + ".Language";
        public const string Create = Default + ".Create";
        public const string Edit = Default + ".Edit";
        public const string Delete = Default + ".Delete";
        public const string SetDefault = Default + ".SetDefault";
    }
}
