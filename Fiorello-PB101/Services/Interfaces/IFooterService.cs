using Fiorello_PB101.ViewModels.Footer;

namespace Fiorello_PB101.Services.Interfaces
{
    public interface IFooterService
    {
        Task<FooterVM> GetFooterDataAsync();
    }
}
