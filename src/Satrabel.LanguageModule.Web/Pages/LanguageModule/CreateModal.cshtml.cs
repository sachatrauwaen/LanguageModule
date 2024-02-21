using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Satrabel.LanguageModule.Languages;
using System;
using Satrabel.LanguageModule.Web.Pages;
using Microsoft.Extensions.Options;
using Volo.Abp.Localization;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Satrabel.LanguageModule.Pages.LanguageOptions
{
    public class CreateModalModel : LanguageModulePageModel
    {
        [BindProperty]
        public CreateLanguageVieuwModel Language { get; set; }

        private readonly ILanguageAppService _LanguageAppService;
        protected AbpLocalizationOptions Options { get; }
        public List<SelectListItem> Languages { get; set; }


        public CreateModalModel(ILanguageAppService LanguageService, IOptions<AbpLocalizationOptions> options)
        {
            _LanguageAppService = LanguageService;
            Options = options.Value;
            
        }
       

        public void OnGet()
        {
            Language = new CreateLanguageVieuwModel();

            Languages = Options.Languages
               .Select(x => new SelectListItem(x.DisplayName, x.CultureName))
               .ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            var lang = Options.Languages.Single(l => l.CultureName == Language.CultureName);


            await _LanguageAppService.CreateAsync(new CreateUpdateLanguageDto()
            {
                CultureName = Language.CultureName,
                UiCultureName = lang.UiCultureName,
                DisplayName = lang.DisplayName,
                FlagIcon = lang.FlagIcon,
               
                

            }) ;
            return NoContent();
        }
        
        public class CreateLanguageVieuwModel
        {
            
            [Required]
            [SelectItems(nameof(Languages))]
            public string CultureName { get; set; } = string.Empty;

           

        }
    }
}
