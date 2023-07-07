using DESIGNOX.Models;
using System.Text.Json;

namespace DESIGNOX.Services
{
    public class ProductShowcasesService
    {
        public ProductShowcasesService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string FileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "default", "showcases.json"); }
        }

        public IEnumerable<ProductShowcase> GetProductShowcases(string pathName)
        {
            using (var fileReader = File.OpenText(FileName.Replace("default", pathName)))
            {

                return JsonSerializer.Deserialize<ProductShowcase[]>(fileReader.ReadToEnd(), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            }
        }

    }
}
