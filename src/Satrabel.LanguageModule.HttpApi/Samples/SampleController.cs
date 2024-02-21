using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;

namespace Satrabel.LanguageModule.Samples;

/*[Area(LanguageModuleRemoteServiceConsts.ModuleName)]
[RemoteService(Name = LanguageModuleRemoteServiceConsts.RemoteServiceName)]
[Route("api/LanguageModule/sample")]
public class SampleController : LanguageModuleController, ISampleAppService
{
    private readonly ISampleAppService _sampleAppService;

    public SampleController(ISampleAppService sampleAppService)
    {
        _sampleAppService = sampleAppService;
    }

    [HttpGet]
    public async Task<SampleDto> GetAsync()
    {
        return await _sampleAppService.GetAsync();
    }

    [HttpGet]
    [Route("authorized")]
    [Authorize]
    public async Task<SampleDto> GetAuthorizedAsync()
    {
        return await _sampleAppService.GetAsync();
    }
}*/
