using DESIGNOX.Models;
using DESIGNOX.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DESIGNOX.Pages
{
    public class WebDesignModel : PageModel
    {

        public WebDesignModel(ProductShowcasesService showcasesService, BannerInfoService bannerInfoService, LinkInfoService linkInfoService)
        {

            productShowcasesService = showcasesService;
            this.bannerInfoService = bannerInfoService;
            linkService = linkInfoService;
        }

        public ProductShowcasesService productShowcasesService;
        public BannerInfoService bannerInfoService;
        public LinkInfoService linkService;

        [BindProperty]
        public IEnumerable<ProductShowcase> ProductShowcases { get; set; } = new List<ProductShowcase>();

        [BindProperty]
        public BannerInfo BannerInfo { get; set; }

        [BindProperty]
        public IEnumerable<PageLink> Links { get; set; }


        public void OnGet()
        {
            ProductShowcases = productShowcasesService.GetProductShowcases("web-design");
            BannerInfo = bannerInfoService.GetBannerInfo("web-design");
            Links = linkService.GetPageLinks("web-design");
        }
    }
}
