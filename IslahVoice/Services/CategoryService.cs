using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static IslahVoice.Model.CategoryModel;

namespace IslahVoice.Services
{
    public class CategoryService
    {
        public async Task<IEnumerable<Category>> getCategory()
        {
            IEnumerable<Category> posts = Enumerable.Empty<Category>();
            var content = "";
            HttpClient client = new HttpClient();
            var RestURL = "http://islahvoice.com/json/categories.php";
            client.BaseAddress = new Uri(RestURL);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage response = await client.GetAsync(RestURL);
            content = await response.Content.ReadAsStringAsync();
            var Items = JsonConvert.DeserializeObject<CategorySource>(content);
            return posts = Items.Categories;

        }
    }
}
