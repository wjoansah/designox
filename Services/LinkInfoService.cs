using DESIGNOX.Models;
using System.Text.Json;

namespace DESIGNOX.Services
{
    public class LinkInfoService
    {

        public LinkInfoService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; set; }

        private string FileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "default", "links.json"); }
        }


        public IEnumerable<PageLink> GetPageLinks(string pathName)
        {
            using (var fileReader = File.OpenText(FileName.Replace("default", pathName)))
            {
                return JsonSerializer.Deserialize<PageLink[]>(fileReader.ReadToEnd(), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            };

        }
    }
}
