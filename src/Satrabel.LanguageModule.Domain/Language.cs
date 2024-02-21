using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Domain.Entities.Auditing;
using Volo.Abp.MultiTenancy;

namespace Satrabel.LanguageModule
{
    public class Language : AuditedAggregateRoot<Guid>, IMultiTenant
    {
        public Guid? TenantId { get; set; }
        public string CultureName { get; set; }
        public string UiCultureName { get; set; }
        public string DisplayName { get; set; }
        public string? FlagIcon { get; set; }
    }
}
