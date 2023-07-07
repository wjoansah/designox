using DESIGNOX.Models;
using DESIGNOX.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DESIGNOX.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, LinkInfoService linkInfoService)
        {
            _logger = logger;
            linkService = linkInfoService;
        }

        public LinkInfoService linkService { get; set; }

        [BindProperty]
        public IEnumerable<PageLink> Links { get; set; } 

        public void OnGet()
        {
            Links = linkService.GetPageLinks("home");
        }
    }
}