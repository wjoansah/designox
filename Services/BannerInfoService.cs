using DESIGNOX.Models;
using System.Text.Json;

namespace DESIGNOX.Services
{
    public class BannerInfoService
    {
        public BannerInfoService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; set; }

        private string FileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "default", "banner.json"); }
        }

        public BannerInfo GetBannerInfo(string pathName)
        {
            using (var fileReader = File.OpenText(FileName.Replace("default", pathName)))
            {
                return JsonSerializer.Deserialize<BannerInfo>(fileReader.ReadToEnd(), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }

        }

    }
}
