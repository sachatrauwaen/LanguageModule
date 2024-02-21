using AutoMapper.Internal.Mappers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using System;
using AutoMapper;
using Satrabel.LanguageModule.Web.Pages;
using Satrabel.LanguageModule.Languages;
using static Satrabel.LanguageModule.Pages.LanguageOptions.CreateModalModel;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;
using Volo.Abp.Localization;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Localization;
using System.Linq;

namespace Satrabel.LanguageModule.Pages.LanguageOptions
{
    public class EditModalModel : LanguageModulePageModel
    {
        [HiddenInput]
        [BindProperty(SupportsGet = true)]
        public Guid Id { get; set; }

        [BindProperty]

        public EditLanguageVieuwModel Language { get; set; }
       

        private readonly ILanguageAppService _languageAppService;
        private readonly IMapper _mapper; // Add IMapper dependency

        public List<SelectListItem> CultureNameOptions { get; set; }
        public List<SelectListItem> UiCultureNameOptions { get; set; }

        protected AbpLocalizationOptions LocalizationOptions { get; }
        public EditModalModel(ILanguageAppService languageAppService, IMapper mapper, IOptions<AbpLocalizationOptions> localizationOptions) // Adjust constructor
        {
            _languageAppService = languageAppService;
            _mapper = mapper;
            LocalizationOptions = localizationOptions.Value;
        }



        public async Task OnGetAsync()
        {
            
           var languageDto = await _languageAppService.GetAsync(Id);
           Language = _mapper.Map<LanguageDto, EditLanguageVieuwModel>(languageDto);
           // Language = new EditLanguageVieuwModel();
            // Example: Populate CultureNameOptions and UiCultureNameOptions
            // Adjust this logic based on how you can fetch culture names and UI culture names
            CultureNameOptions = LocalizationOptions.Languages
                .Select(x => new SelectListItem(x.CultureName, x.CultureName))
                .ToList();

            UiCultureNameOptions = LocalizationOptions.Languages.Where(l => ! string.IsNullOrEmpty(l.UiCultureName))
                .Select(x => new SelectListItem(x.UiCultureName, x.UiCultureName))
                .ToList();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            CreateUpdateLanguageDto Language2 = _mapper.Map<EditLanguageVieuwModel, CreateUpdateLanguageDto>(Language);
            await _languageAppService.UpdateAsync(Id, Language2);
            // Optional: Add a success message to TempData to display on the page after redirect
            TempData["SuccessMessage"] = "Language updated successfully.";
            //return RedirectToPage(); // Redirects back to the current page
            return NoContent();
        }


        public class EditLanguageVieuwModel
        {

            [Required]
            [SelectItems(nameof(CultureNameOptions))]
            public string CultureName { get; set; } = string.Empty;
            [Required]
           [SelectItems(nameof(UiCultureNameOptions))]
            public string UiCultureName { get; set; } = string.Empty;
            [Required]
            [StringLength(128)]
            public string DisplayName { get; set; } = string.Empty;
            [StringLength(128)]
            public string? FlagIcon { get; set; } = string.Empty;


        }
    }
}
