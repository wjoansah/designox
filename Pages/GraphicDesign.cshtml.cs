using DESIGNOX.Models;
using DESIGNOX.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DESIGNOX.Pages
{
    public class GraphicDesignModel : PageModel
    {

        public GraphicDesignModel(BannerInfoService bannerInfoService, LinkInfoService linkInfoService, ProductShowcasesService showcasesService)
        {
            BannerInfoService = bannerInfoService;
            LinkInfoService = linkInfoService;
            ProductShowcasesService = showcasesService;
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
            BannerInfo = BannerInfoService.GetBannerInfo("graphic-design");
            Links = LinkInfoService.GetPageLinks("graphic-design");
            Showcases = ProductShowcasesService.GetProductShowcases("graphic-design");
        }
    }
}
