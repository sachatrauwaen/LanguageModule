using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Satrabel.LanguageModule.EntityFrameworkCore;

public static class LanguageModuleDbContextModelCreatingExtensions
{
    public static void ConfigureLanguageModule(
        this ModelBuilder builder)
    {
        Check.NotNull(builder, nameof(builder));

        /* Configure all entities here. Example:

        builder.Entity<Question>(b =>
        {
            //Configure table & schema name
            b.ToTable(LanguageModuleDbProperties.DbTablePrefix + "Questions", LanguageModuleDbProperties.DbSchema);

            b.ConfigureByConvention();

            //Properties
            b.Property(q => q.Title).IsRequired().HasMaxLength(QuestionConsts.MaxTitleLength);

            //Relations
            b.HasMany(question => question.Tags).WithOne().HasForeignKey(qt => qt.QuestionId);

            //Indexes
            b.HasIndex(q => q.CreationTime);
        });
        */

        builder.Entity<Language>(b =>
        {
            b.ToTable(LanguageModuleDbProperties.DbTablePrefix + "Language", LanguageModuleDbProperties.DbSchema);
            b.ConfigureByConvention(); //auto configure for the base class props
            b.Property(x => x.CultureName).IsRequired().HasMaxLength(128);

            // ADD THE MAPPING FOR THE RELATION

        });
    }
}
