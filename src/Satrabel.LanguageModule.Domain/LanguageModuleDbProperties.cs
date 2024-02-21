namespace Satrabel.LanguageModule;

public static class LanguageModuleDbProperties
{
    public static string DbTablePrefix { get; set; } = "LanguageModule";
    public static string? DbSchema { get; set; } = null;
    public const string ConnectionStringName = "LanguageModule";
}
