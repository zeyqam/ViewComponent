using Fiorello_PB101.Services;
using Fiorello_PB101.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello_PB101.ViewComponents
{
    public class HeaderViewComponent:ViewComponent
    {
        private readonly ISettingService _settigservice;
        public HeaderViewComponent( ISettingService settingService)
        {
            _settigservice = settingService;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View(await _settigservice.GetAllAsync()));
        }
    }
}
