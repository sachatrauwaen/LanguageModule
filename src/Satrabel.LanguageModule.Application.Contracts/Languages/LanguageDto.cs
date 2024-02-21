using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Satrabel.LanguageModule.Languages
{
    public class LanguageDto : EntityDto<Guid>
    {
        public Guid? TenantID { get; set; }
        public string CultureName { get; set; }
        public string UiCultureName { get; set; }
        public string DisplayName { get; set; }
        public string? FlagIcon { get; set; }
    }
}
