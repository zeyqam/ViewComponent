using Fiorello_PB101.Data;
using Fiorello_PB101.Services.Interfaces;
using Fiorello_PB101.ViewModels.Footer;
using Microsoft.EntityFrameworkCore;

namespace Fiorello_PB101.Services
{
    public class FooterService : IFooterService
    {
        private readonly AppDbContext _context;
        public FooterService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<FooterVM> GetFooterDataAsync()
        {
            
                var footerLinks = await _context.FooterLinks.Include(m => m.Links).ToListAsync();
                var contactInfo = await _context.ContactInfos.FirstOrDefaultAsync();

                return new FooterVM
                {
                    FooterLinks = footerLinks,
                    Email = contactInfo?.Email,
                    PhoneNumber = contactInfo?.PhoneNumber
                };
            
        }
    }
}
