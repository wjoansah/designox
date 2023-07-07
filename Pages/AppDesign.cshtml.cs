using DESIGNOX.Models;
using DESIGNOX.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DESIGNOX.Pages
{
    public class AppDesignModel : PageModel
    {

        public AppDesignModel(BannerInfoService bannerInfoService, LinkInfoService linkInfoService, ProductShowcasesService productShowcasesService) {
            BannerInfoService = bannerInfoService;
            LinkInfoService = linkInfoService;
            ProductShowcasesService = productShowcasesService;
        }

        public BannerInfoService BannerInfoService { get; set; }
        public LinkInfoService LinkInfoService { get; set; }
        public ProductShowcasesService ProductShowcasesService { get; set; }


        [BindProperty]
        public BannerInfo BannerInfo { get; set; }

        [BindProperty]
        public IEnumerable<PageLink> Links { get; set; }
        [BindProperty]
        public IEnumerable<ProductShowcase> Showcases { get; set; }
        public void OnGet()
        {
            BannerInfo = BannerInfoService.GetBannerInfo("app-design");
            Links = LinkInfoService.GetPageLinks("app-design");
            Showcases = ProductShowcasesService.GetProductShowcases("app-design");
        }
    }
}
