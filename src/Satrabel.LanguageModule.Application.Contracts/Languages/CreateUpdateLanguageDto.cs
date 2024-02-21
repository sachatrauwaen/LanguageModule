using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Satrabel.LanguageModule
{
    public class CreateUpdateLanguageDto
    {
        [Required]
        [StringLength(128)]
        public string CultureName { get; set; } = string.Empty;
        [Required]
        [StringLength(128)]
        public string UiCultureName { get; set; } = string.Empty;
        [Required]
        [StringLength(128)]
        public string DisplayName { get; set; } = string.Empty;
        [StringLength(128)]
        public string FlagIcon { get; set; } = string.Empty;
    }
}
